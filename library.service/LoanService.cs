using Library.Core.Models;
using Library.Core.Repository;
using Library.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public class LoanService : ILoanService
    {
        private readonly IBookRepository _bookRepository;
        private readonly ICustomersRepository _customerRepository;
        private readonly ILoanRepository _loanRepository;
        public LoanService(ILoanRepository loanRepository,ICustomersRepository customersRepository,IBookRepository bookRepository)
        {
            _loanRepository = loanRepository;
            _bookRepository = bookRepository;
            _customerRepository = customersRepository;
        }

        public async Task<Loan> GetLoanByDateAsync(DateTime date)
        {
            return await _loanRepository.GetLoanByDateAsync(date);
        }

        public async Task<Loan> GetLoanByLoanIdAsync(int loanId)
        {
            return await _loanRepository.GetLoanByIdAsync(loanId);
        }

        public async Task<List<Loan>> GetLoanListAsync()
        {
            return await _loanRepository.GetLoansAsync();
        }


        public async Task<Loan> AddAsync(Loan loan)
        {
            var book = await _bookRepository.GetBookByIdAsync(loan.BookId);
            if (book == null || !book.IsAvailable)
                return null;

            var customer = await _customerRepository.GetCustomerByIdAsync(loan.CustomerId);
            if (customer == null)
                return null;

            var l = await _loanRepository.AddAsync(loan);

            // הספר כבר לא זמין
            book.IsAvailable = false;

            await _loanRepository.SaveAsync();
            return l;

        }
        public async Task<Loan> DeleteAsync(int id)
        {
            var l = await _loanRepository.DeleteAsync(id);
            await _loanRepository.SaveAsync();
            return l;
        }
    }
}

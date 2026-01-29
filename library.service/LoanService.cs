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
        private readonly ILoanRepository _loanRepository;
        public LoanService(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }
       
        public async Task<Loan> GetLoanByDateAsync(DateTime date)
        {
            return await _loanRepository.GetLoanByDateAsync(date);
        }

        public async Task< Loan> GetLoanByLoanIdAsync(int loanId)
        {
          return await _loanRepository.GetLoanByBookIdAsync(loanId);
        }

        public async Task< List<Loan>> GetLoanListAsync()
        {
           return await _loanRepository.GetLoansAsync();
        }

       

    }
}

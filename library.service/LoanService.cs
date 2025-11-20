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
       
        public Loan GetLoanByDate(DateTime date)
        {
            return _loanRepository.GetLoanByDate(date);
        }

        public Loan GetLoanByLoanId(int loanId)
        {
          return _loanRepository.GetLoanById(loanId);
        }

        public List<Loan> GetLoanList()
        {
           return _loanRepository.GetLoans();
        }
    }
}

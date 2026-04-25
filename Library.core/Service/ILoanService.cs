using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Service
{
    public interface ILoanService
    {
        public Task <List<Loan>> GetLoanListAsync();
        public Task <Loan> GetLoanByDateAsync(DateTime date);
        public Task <Loan> GetLoanByLoanIdAsync(int loanId);
      public  Task<Loan> AddAsync(Loan loan);
        public Task<Loan> DeleteAsync(int id);
    }
}

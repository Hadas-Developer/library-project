using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repository
{
    public interface ILoanRepository
    {
        public Task< List<Loan>> GetLoansAsync();
        public Task< Loan> GetLoanByBookIdAsync(int id);
        public Task<Loan> GetLoanByDateAsync(DateTime date);
        public Task SaveAsync();

    }
}

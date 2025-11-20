using Library.Core.Models;
using Library.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        private readonly DataContext _context;

        public Loan GetLoanByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Loan GetLoanById(int id)
        {
            return _context.(loan => loan.Id == id);
        }

        public List<Loan> GetLoans()
        {
            return _context.loans;

        }
    }
}

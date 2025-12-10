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
        public LoanRepository(DataContext context)
        {
            _context = context;
        }

        public Loan GetLoanByDate(DateTime date)
        {
            return _context.loans.Find(c => c.LoanDate == date);
        }

        public Loan GetLoanByBookId(int id)
        {
            return _context.loans.Find(l => l.BookId == id);
        }

        public List<Loan> GetLoans()
        {
            return _context.loans;

        }
    }
}

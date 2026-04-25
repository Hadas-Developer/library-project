using Library.Core.Models;
using Library.Core.Repository;
using Microsoft.EntityFrameworkCore;
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

        public async Task< Loan> GetLoanByDateAsync(DateTime date)
        {
            return await _context.loans.FirstOrDefaultAsync(c => c.LoanDate == date);
        }
        public async Task<Loan> GetLoanByIdAsync(int id)
        {
            return await _context.loans.FirstOrDefaultAsync(l => l.LoanId == id);
        }

        public async Task<Loan> GetLoanByBookIdAsync(int id)
        {
            return await _context.loans.FirstOrDefaultAsync(l => l.BookId == id);
        }
             
        public async Task<List<Loan>> GetLoansAsync()
        {
            return await _context.loans.Include(c => c.Customer).ThenInclude(c=>c.Books).ToListAsync();
        }
        public async Task SaveAsync()
        {
           await _context.SaveChangesAsync();
        }
        public async Task<Loan> AddAsync(Loan loan)
        {
            _context.loans.Add(loan);
            return loan;
        }
        public async Task<Loan> DeleteAsync(int id)
        {
            var loan = await _context.loans.FirstOrDefaultAsync(l => l.LoanId == id);
            if (loan != null)
            {
                _context.loans.Remove(loan);
            }
            return loan;
        }
    }
}

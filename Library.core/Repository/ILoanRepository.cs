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
        public List<Loan> GetLoans();

        public Loan GetLoanByBookId(int id);

        public Loan GetLoanByDate(DateTime date);
    }
}

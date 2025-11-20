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
        public List<Loan> GetLoanList();
        public Loan GetLoanByDate(DateTime date);
        public Loan GetLoanByLoanId(int loanId);
    }
}

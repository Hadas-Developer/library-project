using System.ComponentModel.DataAnnotations;

namespace Library.Core.Models
{
    public class Loan
    {
        [Key]
        public int LoanId { get; set; }
        public int CustomerId { get; set; }
        public int BookId { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate => LoanDate.AddDays(30);
        public Customer Customer { get; set; }
    }
}

namespace LibraryApplicastion.Models
{
    public class LoanPostModel
    {
        public int LoanId { get; set; }
        public int CustomerId { get; set; }
        public int BookId { get; set; }
        public DateTime LoanDate { get; set; }
    }
}

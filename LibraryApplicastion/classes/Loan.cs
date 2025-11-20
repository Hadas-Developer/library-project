namespace LibraryApplicastion.classes
{
    public class Loan
    {
        public int CustomerId { get; set; }
        public int BookId { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate => LoanDate.AddDays(30);
    }
}

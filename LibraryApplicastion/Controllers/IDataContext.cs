namespace LibraryApplicastion.Controllers
{
    public interface IDataContext
    {
        public List<Book> books { get; set; }
        public List<Customer> customers { get; set; }
        public List<Loan> loans { get; set; }
    }
}

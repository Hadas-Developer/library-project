using LibraryApplicastion.Controllers;
using System.Collections.Generic;

namespace LibraryApplicastion.classes
{
    public class FakeData : IDataContext
    {
        public List<Book> books { get; set; }
        public List<Customer> customers { get; set; }
        public List<Loan> loans { get; set; }

        public FakeData()
        {
            books = new List<Book> { new Book { BookId = 210, Title = "דופליקטים", Author = "יונה ספיר", IsAvailable = true, Genre = "פנטזיה" } };

            loans = new List<Loan> { new Loan { CustomerId = 5, BookId = 105, LoanDate = DateTime.Now } };

            customers = new List<Customer> { new Customer { CustomerId = 002, Name = "יעקב לוי ", Address = "שדרות ירושלים", BirthDate = new DateTime(1985, 4, 12) } };

        }

    }
}

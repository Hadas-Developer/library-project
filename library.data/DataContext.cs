using Library.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    public class DataContext:DbContext
    {

        public DbSet<Book> books { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Loan> loans { get; set; }

        //public DataContext()
        //{
        //    books = new List<Book> {  new Book { BookId = 101, Title = "התנקשות", Author = "יונה ספיר", IsAvailable = true,Genre= "מתח"},
        //    new Book { BookId = 102, Title = "מבחן נאמנות", Author = "חוי בר", IsAvailable = false,Genre= "מתח" } };

        //    loans = new List<Loan> { new Loan { CustomerId = 2, BookId = 102, LoanDate = DateTime.Now } };

        //    customers = new List<Customer> {  new Customer { CustomerId = 1, Name = "יוסי לוי", Address = "הרצל 1, תל אביב", BirthDate = new DateTime(1985, 5, 10) },
        //    new Customer { CustomerId = 2, Name = "דנה כהן", Address = "שדרה 5, חיפה", BirthDate = new DateTime(1992, 11, 25) } };

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=library");
        }


    }

}
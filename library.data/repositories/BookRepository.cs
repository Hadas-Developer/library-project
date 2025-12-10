using Library.Core.Models;
using Library.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext _context;
        public BookRepository(DataContext context)
        {
            _context = context;
        }
        public List <Book> GetBookByAuther(string author)
        {
            return _context.books.FindAll(i=> i.Author == author);

        }

        public Book GetBookById(int id)
        {
            return _context.books.Find(b => b.BookId == id);
        }

        public List<Book> GetBooks()
        {
            return _context.books;
        }

        public Book Update(bool isAvailiable,int id)
        {
            var cust = GetBookById(id);
            cust.IsAvailable = isAvailiable;
            return cust;
        }
        public Book Add(Book book)
        {
            var cust = GetBookById(book.BookId);
            if (cust == null)
            {
                _context.books.Add(book);
            }
            return cust;
        }

        public Book DeleteBook(int Bid)
        {
            var cust = GetBookById(Bid);
            if(cust!=null)
                _context.books.Remove(cust);
            return cust;
        }

       

        public Book UpdateBook(bool isAvailiable, int id)
        {
            var b=GetBookById(id);
            if (b != null)
            {
                b.IsAvailable = isAvailiable;
            }
            return b;
        }
    }
}

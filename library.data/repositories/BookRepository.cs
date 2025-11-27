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

        public Book GetBookByAuther(string author)
        {
            return _context.books.Find(a => a.Author == author);

        }

        public Book GetBookById(int id)
        {
            return _context.books.Find(b => b.BookId == id);

        }

        public List<Book> GetBooks()
        {
            return _context.books;
        }

    }
}

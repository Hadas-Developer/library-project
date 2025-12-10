using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repository
{
    public interface IBookRepository
    {
        public List<Book> GetBooks();

        public Book GetBookById(int id);
        public List<Book> GetBookByAuther(string author);

        public Book UpdateBook(bool isAvailiable, int id);
        public Book Add(Book book);
        public Book DeleteBook(int Bid);
    }
}

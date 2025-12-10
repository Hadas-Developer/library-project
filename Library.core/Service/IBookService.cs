using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Service
{
    public interface IBookService
    {
        public List<Book> GetBooks();
        public Book GetBookById(int id);
        public List<Book> GetBookByAuther(string author);

        public Book DeleteBook(int Bid);
        public Book UpdateBook(bool isAvailiable,int id);
        public Book Add(Book book);

    }
}

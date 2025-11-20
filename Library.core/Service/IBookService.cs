using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public interface IBookService
    {
        public List<Book> GetBooks();
        public Book GetBookById(int id);
        public Book GetBooksByAuthor(string author);
    }
}

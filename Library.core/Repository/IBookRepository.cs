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
        public Book GetBookByAuther(string author);

    }
}

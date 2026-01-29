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
        public  Task <List<Book>> GetBooksAsync();
        public  Task <Book> GetBookByIdAsync(int id);
        public  Task< List<Book> >GetBookByAutherAsync(string author);
        public  Task <Book >DeleteBookAsync(int Bid);
        public  Task <Book >UpdateBookAsync( bool isAvailible,int id);
        public  Task<Book >AddAsync(Book book);

    }
}

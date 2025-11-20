using Library.Core.Models;
using Library.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            //חישובים
            _bookRepository = bookRepository;
        }

        public Book GetBookById(int id)
        {
            //חישובים
            return _bookRepository.GetBookById(id);
        }

        public List<Book> GetBooks()
        {

            return _bookRepository.GetBooks();

        }

        public Book GetBooksByAuthor(string author)
        {
            return _bookRepository.GetBookByAuther(author);
        }
    }
}

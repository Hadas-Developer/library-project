using Library.Core.Models;
using Library.Core.Repository;
using Library.Core.Service;
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

        public List<Book> GetBookByAuther(string author)
        {
            return _bookRepository.GetBookByAuther(author);
        }

        public Book UpdateBook(bool isAvailiable,int id)
        {
        var b= _bookRepository.UpdateBook(isAvailiable,id);
            _bookRepository.Save();
            return b;

        }

        public Book Add(Book book)
        {
            var b= _bookRepository.Add(book);
            _bookRepository.Save();
            return b;
        }

        public Book DeleteBook(int bid)
        {
            var b = _bookRepository.DeleteBook(bid);
            _bookRepository.Save();
            return b;
        }


        public int GetAvailableBooksCount()
        {
            var books = _bookRepository.GetBooks();
            return books.Count(b => b.IsAvailable);
        }



    }
}

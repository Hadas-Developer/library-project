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
        public async Task<Book> GetBookByIdAsync(int id)
        {
            //חישובים
            return await _bookRepository.GetBookByIdAsync(id);
        }

        public async Task<List<Book>> GetBooksAsync()
        {

            return await _bookRepository.GetBooksAsync();

        }

        public async Task<List<Book>> GetBookByAutherAsync(string author)
        {
            return await _bookRepository.GetBookByAutherAsync(author);
        }

        public async Task<Book> UpdateBookAsync(bool isAvailiable, int id)
        {
            var b = await _bookRepository.UpdateBookAsync(isAvailiable, id);
            await _bookRepository.SaveAsync();
            return b;

        }

        public async Task<Book> AddAsync(Book book)
        {
            var b = await _bookRepository.AddAsync(book);
            await _bookRepository.SaveAsync();
            return b;
        }

        public async Task<Book> DeleteBookAsync(int bid)
        {
            var b = await _bookRepository.DeleteBookAsync(bid);
            await _bookRepository.SaveAsync();
            return b;
        }


        public async Task< int> GetAvailableBooksCountAsync()
        {
            var books =await _bookRepository.GetBooksAsync();
            return books.Count(b => b.IsAvailable);
        }



    }
}

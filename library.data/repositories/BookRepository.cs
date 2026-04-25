using Library.Core.Models;
using Library.Core.Repository;
using Microsoft.EntityFrameworkCore;
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
        public async Task<List<Book>> GetBookByAutherAsync(string author)
        {
            return await _context.books
                        .Where(b => b.Author == author)
                        .ToListAsync(); ;

        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await _context.books.FirstOrDefaultAsync(b => b.BookId == id);
        }

        public async Task<List<Book>> GetBooksAsync()
        {
            return await _context.books.ToListAsync();
        }

        public async Task<Book> Update(bool isAvailiable, int id)
        {
            var cust = await GetBookByIdAsync(id);
            cust.IsAvailable = isAvailiable;
            return cust;
        }
        public async Task<Book> AddAsync(Book book)
        {
            _context.books.Add(book);
            return book;
        }

        public async Task<Book> DeleteBookAsync(int Bid)
        {
            var cust = await GetBookByIdAsync(Bid);
            if (cust != null)
                _context.books.Remove(cust);
            return cust;
        }



        public async Task<Book> UpdateBookAsync(bool isAvailiable, int id)
        {
            var b = await GetBookByIdAsync(id);
            if (b != null)
            {
                b.IsAvailable = isAvailiable;
            }
            return b;
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

using Library.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryApplicastion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IDataContext LibraryContext;
        public BookController(IDataContext context)
        {
            LibraryContext = context;
        }
        // GET: api/<BookController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return LibraryContext.books;
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            var book = LibraryContext.books.FindIndex(b => b.BookId == id);
            return LibraryContext.books[book];
        }

        // GET api/<BookController>/5
        //[HttpGet("{name}")]
        //public Book Get(string nameBook)
        //{
        //    var book = LibraryContext.books.FindIndex(b => b.Title == nameBook);
        //    return LibraryContext.books[book];
        //}

        // POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] Book value)
        {
            LibraryContext.books.Add(value);
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Book value)// נראה לי שפה צריך רק אם הוא זמין וג'נר לא את כל הספר וכן הלאה על הכל. לשאול את יעל???????????????????????????????????????????????????????????????????????????????.
        {
            var index = LibraryContext.books.FindIndex(b => b.BookId == id);
            LibraryContext.books[index].IsAvailable = value.IsAvailable;
            LibraryContext.books[index].Genre = value.Genre;


        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var book = LibraryContext.books.Find(e => e.BookId == id);
            LibraryContext.books.Remove(book);
        }
    }
}

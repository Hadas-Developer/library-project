using Library.Core.Models;
using Library.Core.Service;
using Library.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryApplicastion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService context)
        {
            _bookService = context;
        }
        // GET: api/<BookController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _bookService.GetBooks();
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            var book = _bookService.GetBookById(id);
            return book;
        }


        // POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] Book value)
        {
            _bookService.GetBooks().Add(value);
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Book value)// נראה לי שפה צריך רק אם הוא זמין וג'נר לא את כל הספר וכן הלאה על הכל. לשאול את יעל???????????????????????????????????????????????????????????????????????????????.
        {
            var index = _bookService.GetBookById(id);
            index.IsAvailable = value.IsAvailable;
            index.Genre = value.Genre;


        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var book = _bookService.GetBookById(id);
            _bookService.GetBooks().Remove(book);
        }
    }
}

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
        public ActionResult Get()
        {
            return Ok(_bookService.GetBooks());
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var index = _bookService.GetBookById(id);
            if (index != null)
            {
                return Ok(index);
            }
            return NotFound();
        }


        // POST api/<EventsController>
        [HttpPost]
        public ActionResult Post([FromBody] Book value)
        {
            var book = _bookService.Add(value);
            if (book == null)
            {
                return Ok(value);
            }
            return BadRequest();

        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Book value)
        {
            var b = _bookService.UpdateBook(value.IsAvailable,id);
            if (b != null)
            {
                return Ok(value);
            }
            return BadRequest();
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var c = _bookService.DeleteBook(id);
            if (c != null)
            {
                return Ok(c);
            }
            return NotFound();

        }
    }
}

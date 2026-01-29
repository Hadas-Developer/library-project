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
        public async Task<ActionResult> Get()
        {
            return Ok(await _bookService.GetBooksAsync());
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public async Task< ActionResult> Get(int id)
        {
            var index =await _bookService.GetBookByIdAsync(id);
            if (index != null)
            {
                return Ok(index);
            }
            return NotFound();
        }


        // POST api/<EventsController>
        [HttpPost]
        public async Task< ActionResult> Post([FromBody] Book value)
        {
            var book =await _bookService.AddAsync(value);
            if (book == null)
            {
                return Ok(value);
            }
            return BadRequest();

        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id,  bool isa)
        {
            var b =await _bookService.UpdateBookAsync(isa,id);
            if (b != null)
            {
                return Ok(isa);
            }
            return BadRequest();
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public async Task< ActionResult> Delete(int id)
        {
            var c =await _bookService.DeleteBookAsync(id);
            if (c != null)
            {
                return Ok(c);
            }
            return NotFound();

        }
    }
}

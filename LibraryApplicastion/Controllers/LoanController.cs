using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryApplicastion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        private readonly IDataContext LibraryContext;
        public LoanController(IDataContext context)
        {
            LibraryContext = context;
        }
        // GET: api/<LoanController>
        [HttpGet]
        public IEnumerable<Loan> Get()
        {
            return LibraryContext.loans;
        }

        // GET api/<LoanController>/5
        [HttpGet("{id}")]
        public Loan Get(int id)
        {
            var ind = LibraryContext.loans.FindIndex(l => l.BookId == id);
            return LibraryContext.loans[ind];
        }

        // POST api/<LoanController>
        [HttpPost]
        public void Post([FromBody] Loan value)
        {
            LibraryContext.loans.Add(value);
        }

        //// PUT api/<LoanController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] Loan value)
        //{
        //   אי אפשר לבצע עדכון להשאלה שהתבצעה אפשר רק להחזיר ולחמוק
        //}

        // DELETE api/<LoanController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = LibraryContext.loans.FindIndex(l => l.BookId == id);
            LibraryContext.loans.Remove(LibraryContext.loans[index]);
        }
    }
}

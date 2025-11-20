using Library.Core.Models;
using Library.Core.Service;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryApplicastion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        private readonly ILoanService _libraryContext;
        public LoanController(ILoanService context)
        {
            _libraryContext = context;
        }
        // GET: api/<LoanController>
        [HttpGet]
        public IEnumerable<Loan> Get()
        {
            return _libraryContext.GetLoanList();
        }

        // GET api/<LoanController>/5
        [HttpGet("{id}")]
        public Loan Get(int id)
        {
            var loan = _libraryContext.GetLoanByLoanId(id);
            return loan;
        }

        // POST api/<LoanController>
        [HttpPost]
        public void Post([FromBody] Loan value)
        {
            _libraryContext.GetLoanList().Add(value);
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
            var index = _libraryContext.GetLoanList().FindIndex(l => l.BookId == id);
            _libraryContext.GetLoanList().Remove(_libraryContext.GetLoanList()[index]);
        }
    }
}

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
        public async Task< IEnumerable<Loan>> Get()
        {
            return await _libraryContext.GetLoanListAsync();
        }

        // GET api/<LoanController>/5
        [HttpGet("{id}")]
        public async Task< Loan > Get(int id)
        {
            var loan =await _libraryContext.GetLoanByLoanIdAsync(id);
            return loan;
        }

        // POST api/<LoanController>
        [HttpPost]
        public async Task Post([FromBody] Loan value)
        {
            var l = await _libraryContext.GetLoanListAsync();
                l.Add(value);
        }

        //// PUT api/<LoanController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] Loan value)
        //{
        //   אי אפשר לבצע עדכון להשאלה שהתבצעה אפשר רק להחזיר ולחמוק
        //}

        // DELETE api/<LoanController>/5
        [HttpDelete("{id}")]
        public async Task< ActionResult >Delete(int id)
        {
            // var index =await _libraryContext.GetLoanByLoanIdAsync(id);
            //if (index != null)
            // {
            //   await  _libraryContext.GetLoanListAsync().Remove(index);
            //     return Ok(index);
            // }
            var loans = await _libraryContext.GetLoanListAsync();
            var loan = await _libraryContext.GetLoanByLoanIdAsync(id);

            if (loan != null)
            {
                loans.Remove(loan);
                return Ok(loan);
            }
            return BadRequest();
        }
    }
}

using AutoMapper;
using Library.Core.DTO;
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
        private readonly IMapper _mapper;

        public LoanController(ILoanService context, IMapper mapper)
        {
            _libraryContext = context;
            _mapper = mapper;
        }
        // GET: api/<LoanController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(_mapper.Map<List<LoanDTO>>(await _libraryContext.GetLoanListAsync()));
        }

        // GET api/<LoanController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var loan = await _libraryContext.GetLoanByLoanIdAsync(id);

            if (loan == null)
                return NotFound();

            return Ok(_mapper.Map<LoanDTO>(loan));
        }

        // POST api/<LoanController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] LoanDTO value)
        {
            var loan = _mapper.Map<Loan>(value);

            var result = await _libraryContext.AddAsync(loan);

            if (result == null)
                return BadRequest("Loan failed");

            return Ok(_mapper.Map<LoanDTO>(result));
        }

        //// PUT api/<LoanController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] Loan value)
        //{
        //   אי אפשר לבצע עדכון להשאלה שהתבצעה אפשר רק להחזיר ולחמוק
        //}

        // DELETE api/<LoanController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var loan = await _libraryContext.DeleteAsync(id);

            if (loan != null)
            {
                return Ok(loan);
            }

            return NotFound();
        }
    }
}

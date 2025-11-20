using Library.Core.Models;
using Library.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryApplicastion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    //  public static List<Events> events = new List<Events>(){ new Events {Id=1,Title="wedding",Start=new DateTime(),End=new DateTime()}, new Events { Id = 2, Title = "Bar-mitzva", Start = new DateTime(), End = new DateTime() } };

    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customerService.GetCustomersList();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var index = _customerService.GetCustomerById(id);
            if (index != null)
            {
                return Ok(index);
            }
            return NotFound();
        }

        // POST api/<CustomerController>
        [HttpPost]
        public ActionResult Post([FromBody] Customer value)
        {
            var cust = _customerService.GetCustomerById(value.CustomerId);
            if (cust != null)
            {
                _customerService.GetCustomersList().Add(value);
                return Ok(value);
            }
            return BadRequest();

        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Customer value)
        {
            var cust = _customerService.GetCustomerById(id);
            if (cust != null)
            {
                //לשלוח את הוליו לפונ' UPDATE
                return Ok(value);
            }
            return BadRequest();


        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var cust = _customerService.GetCustomersList().Find(c => c.CustomerId == id);
            _customerService.GetCustomersList().Remove(cust);
        }
    }
}

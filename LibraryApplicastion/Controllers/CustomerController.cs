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
        public ActionResult Get()
        {
            return Ok(_customerService.GetCustomersList());
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
            var cust = _customerService.Add(value);
            if (cust == null)
            {
                return Ok(value);
            }
            return BadRequest();

        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Customer value)
        {
            var cust = _customerService.UpdateCustomer(id,value.NumBookLimit,value.Address);
            if (cust != null)
            {
                return Ok(value);
            }
            return BadRequest();
        }


        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var c = _customerService.DeleteCustomer(id);
            if (c != null)
            {
                return Ok(c);
            }
            return NotFound();

        }
    }
}

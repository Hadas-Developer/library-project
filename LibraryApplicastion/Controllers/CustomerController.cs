using Library.Core.Models;
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
        private readonly IDataContext LibraryContext;
        public CustomerController(IDataContext context)
        {
            LibraryContext = context;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return LibraryContext.customers;
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var index = LibraryContext.customers.Find(c => c.CustomerId == id);
            if (index != null)
            {
                return Ok(index);
            }
            return NotFound();
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] Customer value)
        {
            LibraryContext.customers.Add(value);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer value)
        {
            var index = LibraryContext.customers.FindIndex(c => c.CustomerId == id);
            LibraryContext.customers[index].Address = value.Address;
            LibraryContext.customers[index].BirthDate = value.BirthDate;
            LibraryContext.customers[index].Name = value.Name;
            LibraryContext.customers[index].NumBookLimit = value.NumBookLimit;

        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var cust = LibraryContext.customers.Find(c => c.CustomerId == id);
            LibraryContext.customers.Remove(cust);
        }
    }
}

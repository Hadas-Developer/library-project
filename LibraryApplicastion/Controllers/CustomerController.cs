using AutoMapper;
using Library.Core.Models;
using Library.Core.Service;
using Library.Service;
using LibraryApplicastion.Models;
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
        private readonly IMapper _mapper;

        public CustomerController(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;

        }
        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _customerService.GetCustomersListAsync());
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var index = await _customerService.GetCustomerByIdAsync(id);
            if (index != null)
            {
                return Ok(index);
            }
            return NotFound();
        }

        // POST api/<CustomerController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CustomerPostModel value)
        {
            var customer = _mapper.Map<Customer>(value);

            var cust = await _customerService.AddAsync(customer);

            if (cust != null)
            {
                return Ok(cust);
            }

            return BadRequest();

        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] CustomerPutModel value)
        {
            var cust = await _customerService.UpdateCustomerAsync(id,value.NumBookLimit,value.Address,value.phone);

            if (cust != null)
            {
                cust.phone = value.phone;
                return Ok(cust);
            }
            return BadRequest();
        }


        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var c = await _customerService.DeleteCustomerAsync(id);
            if (c != null)
            {
                return Ok(c);
            }
            return NotFound();

        }
    }
}

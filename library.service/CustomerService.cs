using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerService _customerService;
        public CustomerService(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public Customer GetCustomerByBirthdate(DateTime date)
        {
            //חישובים
           return _customerService.GetCustomerByBirthdate(date);
        }

        public Customer GetCustomerById(int id)
        {
           return _customerService.GetCustomerById(id);
        }

        public List<Customer> GetCustomersList()
        {
            return _customerService.GetCustomersList();

        }
    }
}

using Library.Core.Models;
using Library.Core.Repository;
using Library.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomersRepository _customerRepository;
        public CustomerService(ICustomersRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer GetCustomerByBirthdate(DateTime date)
        {
          
            return _customerRepository.GetCustomerByBirthDate(date);
        }

        public Customer GetCustomerById(int id)
        {
            return _customerRepository.GetCustomerById(id);
        }

        public List<Customer> GetCustomersList()
        {
            return _customerRepository.GetCustomers();

        }
        public Customer DeleteCustomer(int id)
        {
            var cust = _customerRepository.DeleteCustomer(id);
            _customerRepository.GetCustomers().Remove(cust);
            return cust;    
        }


    }
}

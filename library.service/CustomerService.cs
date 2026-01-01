using Library.Core.Models;
using Library.Core.Repository;
using Library.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            var c = _customerRepository.DeleteCustomer(id);
            ///..
            ///..
            ///

            _customerRepository.Save();
            return c;
        }

        public Customer UpdateCustomer(int id, int numBook, string address)
        {

            var c = _customerRepository.Update(id, numBook, address);
            _customerRepository.Save();
            return c;

        }

        public Customer Add(Customer customer)
        {
            var c = _customerRepository.Add(customer);
            _customerRepository.Save();
            return c;
        }

        ////
        

    }
}

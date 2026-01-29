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

        public async Task<Customer> GetCustomerByBirthdateAsync(DateTime date)
        {

            return await _customerRepository.GetCustomerByBirthDateAsync(date);
        }

        public async Task< Customer> GetCustomerByIdAsync(int id)
        {
            return await _customerRepository.GetCustomerByIdAsync(id);
        }

        public async Task< List<Customer>> GetCustomersListAsync()
        {
            return await _customerRepository.GetCustomersAsync();

        }
        public async Task< Customer> DeleteCustomerAsync(int id)
        {
            var c =await _customerRepository.DeleteCustomerAsync(id);

            await _customerRepository.SaveAsync();
            return c;
        }

        public async Task<Customer> UpdateCustomerAsync(int id, int numBook, string address)
        {

            var c =await _customerRepository.UpdateAsync(id, numBook, address);
          await  _customerRepository.SaveAsync();
            return c;

        }

        public async Task< Customer> AddAsync(Customer customer)
        {
            var c =await _customerRepository.AddAsync(customer);
            await _customerRepository.SaveAsync();
            return c;
        }

        

    }
}

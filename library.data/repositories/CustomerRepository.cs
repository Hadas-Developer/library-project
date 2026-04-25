using Library.Core.Models;
using Library.Core.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repositories
{
    public class CustomerRepository : ICustomersRepository
    {
        private readonly DataContext _context;
        public CustomerRepository(DataContext context)
        {
            _context = context;
        }

        public async Task< Customer> GetCustomerByBirthDateAsync(DateTime date)
        {
            return await _context.customers.FirstOrDefaultAsync(c => c.BirthDate == date);
        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            return await _context.customers.FirstOrDefaultAsync(c => c.CustomerId == id);
        }

        public async Task<List<Customer>> GetCustomersAsync()
        {
            return await _context.customers.Include(x => x.Books).ToListAsync();

        }

        public async Task<Customer> UpdateAsync(int id, int numOfBooks, string address, string phone)
        {
            var cust = await GetCustomerByIdAsync(id);

            if (cust != null)
            {
                cust.NumBookLimit = numOfBooks;
                cust.Address = address;
                cust.phone = phone;
            }

            return cust;
        }

        public async Task<Customer> AddAsync(Customer c)
        {
            _context.customers.Add(c);
            return c;
        }

        public async Task<Customer> DeleteCustomerAsync(int id)
        {
            var cust = await GetCustomerByIdAsync(id);
            if (cust != null)
                _context.customers.Remove(cust);
            return cust;
        }
        public async Task SaveAsync()
        {
           await _context.SaveChangesAsync();
        }

     
    }
}

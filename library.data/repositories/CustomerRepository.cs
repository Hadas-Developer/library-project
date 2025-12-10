using Library.Core.Models;
using Library.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public Customer GetCustomerByBirthDate(DateTime date)
        {
            return _context.customers.Find(c => c.BirthDate == date);
        }

        public Customer GetCustomerById(int id)
        {
            return _context.customers.Find(c => c.CustomerId == id);
        }

        public List<Customer> GetCustomers()
        {
            return _context.customers;

        }

        public Customer Update(int id, int numOfBooks, string address)
        {
            var cust = GetCustomerById(id);
            cust.NumBookLimit = numOfBooks;
            cust.Address = address;
            return cust;
        }

        public Customer Add(Customer c)
        {
            var cust = GetCustomerById(c.CustomerId);
            if (cust == null)
                _context.customers.Add(c);
            return cust;
        }

        public Customer DeleteCustomer(int id)
        {
            var cust = GetCustomerById(id);
            if (cust != null)
                _context.customers.Remove(cust);
            return cust;
        }
    }
}

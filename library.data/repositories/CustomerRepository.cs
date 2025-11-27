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

        public Customer DeleteCustomer(int id)
        {
            return _context.customers.Find(c => c.CustomerId == id);
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


 
    }
}

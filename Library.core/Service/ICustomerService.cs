using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Service
{
    public interface ICustomerService
    {
        public Task< List<Customer> >GetCustomersListAsync();
        public Task< Customer> GetCustomerByIdAsync(int id);
        public Task< Customer> GetCustomerByBirthdateAsync(DateTime date);
        public Task< Customer> DeleteCustomerAsync(int id);
        public Task< Customer> UpdateCustomerAsync(int id,int numBook,string address);
        public Task< Customer> AddAsync(Customer customer);
        
    }
}

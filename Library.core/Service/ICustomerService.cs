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
        public List<Customer> GetCustomersList();
        public Customer GetCustomerById(int id);
        public Customer GetCustomerByBirthdate(DateTime date);

        public Customer DeleteCustomer(int id);
        public Customer UpdateCustomer(int id,int numBook,string address);
        public Customer Add(Customer customer);
        
    }
}

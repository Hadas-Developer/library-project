using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repository
{
    public interface ICustomersRepository
    {
        public  Task< List<Customer>> GetCustomersAsync();

        public  Task <Customer> GetCustomerByIdAsync(int id);
        public  Task<Customer> GetCustomerByBirthDateAsync(DateTime date);
        public  Task<Customer> DeleteCustomerAsync(int id);
        public  Task<Customer> UpdateAsync(int id, int numOfBooks, string address,string phone);
        public  Task<Customer> AddAsync(Customer c);
        public  Task SaveAsync();


    }
}

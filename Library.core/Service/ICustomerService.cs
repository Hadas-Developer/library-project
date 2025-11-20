using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public interface ICustomerService
    {
        public List<Customer> GetCustomersList();
        public Customer GetCustomerById(int id);
        //public Customer GetCustomerByName(string name);
        public Customer GetCustomerByBirthdate(DateTime date);

    }
}

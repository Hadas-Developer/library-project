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
        public List<Customer> GetCustomers();

        public Customer GetCustomerById(int id);

    }
}

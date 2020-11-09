using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Repository
{
    public interface ICustomerRepository
    {
        public List<Customer> GetAll();

        public Customer GetCustomer(int id);

        public Customer AddCustomer(Customer customer);

        public Customer UpdateCustomer(Customer customer);

        public void DeleteCustomer(int id);

        public bool Exists(int id);
    }
}

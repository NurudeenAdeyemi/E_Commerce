using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public readonly ECommerceContext _dbContext;

        public CustomerRepository (ECommerceContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Customer AddCustomer(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
            return customer;
        }

        public void DeleteCustomer(int id)
        {
            var customer = GetCustomer(id);

            if (customer != null)
            {
                _dbContext.Customers.Remove(customer);
                _dbContext.SaveChanges();
            }
        }

        public bool Exists(int id)
        {
            return _dbContext.Customers.Any(e => e.Id == id);
        }

        public List<Customer> GetAll()
        {
            return _dbContext.Customers.ToList();
        }

        public Customer GetCustomer(int id)
        {
            return _dbContext.Customers.Find(id);
        }

        public Customer UpdateCustomer(Customer customer)
        {
            _dbContext.Customers.Update(customer);
            _dbContext.SaveChanges();
            return customer;
        }
    }
}

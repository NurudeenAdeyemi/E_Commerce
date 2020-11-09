using E_Commerce.Models;
using E_Commerce.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Service
{
    public class CustomerService : ICustomerService
    {
        public readonly ICustomerRepository customerRepository;

        public CustomerService (ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public Customer AddCustomer(Customer customer)
        {
            return customerRepository.AddCustomer(customer);
        }

        public void DeleteCustomer(int id)
        {
            customerRepository.DeleteCustomer(id);
        }

        public bool Exists(int id)
        {
            return customerRepository.Exists(id);
        }

        public List<Customer> GetAll()
        {
            return customerRepository.GetAll();
        }

        public Customer GetCustomer(int id)
        {
            return customerRepository.GetCustomer(id);
        }

        public Customer UpdateCustomer(Customer customer)
        {
            return customerRepository.UpdateCustomer(customer);
        }
    }
}

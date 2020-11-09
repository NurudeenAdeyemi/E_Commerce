using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Repository
{
    public interface IProductRepository
    {
        public List<Product> GetAll();

        public Product GetProduct(int id);

        public Product AddProduct(Product product);

        public Product UpdateProduct(Product product);

        public void DeleteProduct(int id);

        public bool Exists(int id);
    }
}

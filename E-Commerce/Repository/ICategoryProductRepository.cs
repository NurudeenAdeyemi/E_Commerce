using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Repository
{
    public interface ICategoryProductRepository
    {
        public List<CategoryProduct> GetAll();

        public CategoryProduct GetCategoryProduct (int id);

        public CategoryProduct AddCategoryProduct(CategoryProduct categoryProduct);

        public CategoryProduct UpdateCategoryProduct(CategoryProduct categoryProduct);

        public void DeleteCategoryProduct(int id);

        public bool Exists(int id);
    }
}

using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Repository
{
    public class CategoryProductRepository : ICategoryProductRepository
    {
        private readonly ECommerceContext _dbContext;

        public CategoryProductRepository (ECommerceContext dbContext)
        {
            _dbContext = dbContext;
        }

        public CategoryProduct AddCategoryProduct(CategoryProduct categoryProduct)
        {
            _dbContext.CategoryProducts.Add(categoryProduct);
            _dbContext.SaveChanges();
            return categoryProduct;
        }

        public void DeleteCategoryProduct(int id)
        {
            var categoryProduct = GetCategoryProduct(id);

            if (categoryProduct != null)
            {
                _dbContext.CategoryProducts.Remove(categoryProduct);
                _dbContext.SaveChanges();
            }
        }

        public bool Exists(int id)
        {
            return _dbContext.CategoryProducts.Any(e => e.Id == id);
        }

        public List<CategoryProduct> GetAll()
        {
            return _dbContext.CategoryProducts.ToList();
        }

        public CategoryProduct GetCategoryProduct(int id)
        {
            return _dbContext.CategoryProducts.Find(id);
        }

        public CategoryProduct UpdateCategoryProduct(CategoryProduct categoryProduct)
        {
            _dbContext.CategoryProducts.Update(categoryProduct);
            _dbContext.SaveChanges();
            return categoryProduct;
        }
    }
}

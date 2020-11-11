using E_Commerce.Models;
using E_Commerce.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Service
{
    public class CategoryProductService : ICategoryProductService
    {
        private readonly ICategoryProductRepository categoryProductRepository;

        public CategoryProductService (ICategoryProductRepository categoryProductRepository)
        {
            this.categoryProductRepository = categoryProductRepository;
        }

        public CategoryProduct AddCategoryProduct(CategoryProduct categoryProduct)
        {
            return categoryProductRepository.AddCategoryProduct(categoryProduct);
        }

        public void DeleteCategoryProduct(int id)
        {
            categoryProductRepository.DeleteCategoryProduct(id);
        }

        public bool Exists(int id)
        {
            return categoryProductRepository.Exists(id);
        }

        public List<CategoryProduct> GetAll()
        {
            return categoryProductRepository.GetAll();
        }

        public CategoryProduct GetCategoryProduct(int id)
        {
            return categoryProductRepository.GetCategoryProduct(id);
        }

        public CategoryProduct UpdateCategoryProduct(CategoryProduct categoryProduct)
        {
            return categoryProductRepository.UpdateCategoryProduct(categoryProduct);
        }
    }
}

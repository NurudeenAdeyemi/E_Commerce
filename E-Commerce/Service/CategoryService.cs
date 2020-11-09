using E_Commerce.Models;
using E_Commerce.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService (ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public Category AddCategory(Category category)
        {
            return categoryRepository.AddCategory(category);
        }

        public void DeleteCategory(int id)
        {
            categoryRepository.DeleteCategory(id);
        }

        public bool Exists(int id)
        {
            return categoryRepository.Exists(id);
        }

        public List<Category> GetAll()
        {
            return categoryRepository.GetAll();
        }

        public Category GetCategory(int id)
        {
            return categoryRepository.GetCategory(id);
        }

        public Category UpdateCategory(Category category)
        {
            return categoryRepository.UpdateCategory(category);
        }
    }
}

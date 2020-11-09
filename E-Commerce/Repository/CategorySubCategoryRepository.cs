using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Repository
{
    public class CategorySubCategoryRepository : ICategorySubCategoryRepository
    {
        private readonly ECommerceContext _dbContext;

        public CategorySubCategoryRepository (ECommerceContext dbContext)
        {
            _dbContext = dbContext;
        }

        public CategorySubCategory AddCategorySubCategory(CategorySubCategory categorySubCategory)
        {
            _dbContext.CategorySubCategories.Add(categorySubCategory);
            _dbContext.SaveChanges();
            return categorySubCategory;
        }

        public void DeleteCategorySubCategory(int id)
        {
            var categorySubCategory = GetCategorySubCategory(id);

            if (categorySubCategory != null)
            {
                _dbContext.CategorySubCategories.Remove(categorySubCategory);
                _dbContext.SaveChanges();
            }
        }

        public bool Exists(int id)
        {
            return _dbContext.CategorySubCategories.Any(e => e.Id == id);
        }

        public List<CategorySubCategory> GetAll()
        {
            return _dbContext.CategorySubCategories.ToList();
        }

        public CategorySubCategory GetCategorySubCategory(int id)
        {
            return _dbContext.CategorySubCategories.Find(id);
        }

        public CategorySubCategory UpdateCategorySubCategory(CategorySubCategory categorySubCategory)
        {
            _dbContext.CategorySubCategories.Update(categorySubCategory);
            _dbContext.SaveChanges();
            return categorySubCategory;
        }
    }
}

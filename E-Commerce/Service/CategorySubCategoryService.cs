using E_Commerce.Models;
using E_Commerce.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Service
{
    public class CategorySubCategoryService : ICategorySubCategoryService
    {
        private readonly ICategorySubCategoryRepository categorySubCategoryRepository;

        public CategorySubCategoryService (ICategorySubCategoryRepository categorySubCategoryRepository)
        {
            this.categorySubCategoryRepository = categorySubCategoryRepository;
        }

        public CategorySubCategory AddCategorySubCategory(CategorySubCategory categorySubCategory)
        {
            return categorySubCategoryRepository.AddCategorySubCategory(categorySubCategory);
        }

        public void DeleteCategorySubCategory(int id)
        {
            categorySubCategoryRepository.DeleteCategorySubCategory(id);
        }

        public bool Exists(int id)
        {
            return categorySubCategoryRepository.Exists(id);
        }

        public List<CategorySubCategory> GetAll()
        {
            return categorySubCategoryRepository.GetAll();
        }

        public CategorySubCategory GetCategorySubCategory(int id)
        {
            return categorySubCategoryRepository.GetCategorySubCategory(id);
        }

        public CategorySubCategory UpdateCategorySubCategory(CategorySubCategory categorySubCategory)
        {
            return categorySubCategoryRepository.UpdateCategorySubCategory(categorySubCategory);
        }
    }
}

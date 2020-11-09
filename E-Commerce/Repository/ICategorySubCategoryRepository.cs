using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Repository
{
    public interface ICategorySubCategoryRepository
    {
        public List<CategorySubCategory> GetAll();

        public CategorySubCategory GetCategorySubCategory(int id);

        public CategorySubCategory AddCategorySubCategory(CategorySubCategory categorySubCategory);

        public CategorySubCategory UpdateCategorySubCategory(CategorySubCategory categorySubCategory);

        public void DeleteCategorySubCategory(int id);

        public bool Exists(int id);
    }
}

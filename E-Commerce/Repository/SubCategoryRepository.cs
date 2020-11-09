using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Repository
{
    public class SubCategoryRepository : ISubCategoryRepository
    {
        private readonly ECommerceContext _dbContext;

        public SubCategoryRepository (ECommerceContext dbContext)
        { 
            _dbContext = dbContext;
        }

        public SubCategory AddSubCategory(SubCategory subCategory)
        {
            _dbContext.SubCategories.Add(subCategory);
            _dbContext.SaveChanges();
            return subCategory;
        }

        public void DeleteSubCategory(int id)
        {
            var subCategory = GetSubCategory(id);

            if (subCategory != null)
            {
                _dbContext.SubCategories.Remove(subCategory);
                _dbContext.SaveChanges();
            }
        }

        public bool Exists(int id)
        {
            return _dbContext.SubCategories.Any(e => e.Id == id);
        }

        public List<SubCategory> GetAll()
        {
            return _dbContext.SubCategories.ToList();
        }

        public SubCategory GetSubCategory(int id)
        {
            return _dbContext.SubCategories.Find(id);
        }

        public SubCategory UpdateSubCategory(SubCategory subCategory)
        {
            _dbContext.SubCategories.Update(subCategory);
            _dbContext.SaveChanges();
            return subCategory;
        }
    }
}

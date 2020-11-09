using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Repository
{
    public class SubCategoryBrandRepository : ISubCategoryBrandRepository
    {
        private readonly ECommerceContext _dbContext;

        public SubCategoryBrandRepository (ECommerceContext dbContext)
        {
            _dbContext = dbContext;
        }

        public SubCategoryBrand AddSubCategoryBrand(SubCategoryBrand subCategoryBrand)
        {
            _dbContext.SubCategoryBrands.Add(subCategoryBrand);
            _dbContext.SaveChanges();
            return subCategoryBrand;
        }

        public void DeleteSubCategoryBrand(int id)
        {
            var subCategoryBrand = GetSubCategoryBrand(id);

            if (subCategoryBrand != null)
            {
                _dbContext.SubCategoryBrands.Remove(subCategoryBrand);
                _dbContext.SaveChanges();
            }
        }

        public bool Exists(int id)
        {
            return _dbContext.SubCategoryBrands.Any(e => e.Id == id);
        }

        public List<SubCategoryBrand> GetAll()
        {
            return _dbContext.SubCategoryBrands.ToList();
        }

        public SubCategoryBrand GetSubCategoryBrand(int id)
        {
            return _dbContext.SubCategoryBrands.Find(id);
        }

        public SubCategoryBrand UpdateSubCategoryBrand(SubCategoryBrand subCategoryBrand)
        {
            _dbContext.SubCategoryBrands.Update(subCategoryBrand);
            _dbContext.SaveChanges();
            return subCategoryBrand;
        }
    }
}

using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Repository
{
    public class BrandRepository : IBrandRepository
    {
        private readonly ECommerceContext _dbContext;

        public BrandRepository (ECommerceContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Brand AddBrand(Brand brand)
        {
            _dbContext.Brands.Add(brand);
            _dbContext.SaveChanges();
            return brand;
        }

        public void DeleteBrand(int id)
        {
            var brand = GetBrand(id);
            if (brand != null)
            {
                _dbContext.Brands.Remove(brand);
                _dbContext.SaveChanges();
            }
        }

        public bool Exists(int id)
        {
            return _dbContext.Brands.Any(e => e.Id == id);
        }

        public List<Brand> GetAll()
        {
            return _dbContext.Brands.ToList();
        }

        public Brand GetBrand(int id)
        {
            return _dbContext.Brands.Find(id);
        }

        public Brand UpdateBrand(Brand brand)
        {
            _dbContext.Brands.Update(brand);
            _dbContext.SaveChanges();
            return brand;
        }
    }
}

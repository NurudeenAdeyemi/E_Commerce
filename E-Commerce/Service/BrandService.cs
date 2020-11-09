using E_Commerce.Models;
using E_Commerce.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Service
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository brandRepository;

        public BrandService (IBrandRepository brandRepository)
        {
            this.brandRepository = brandRepository;
        }

        public Brand AddBrand(Brand brand)
        {
            return brandRepository.AddBrand(brand);
        }

        public void DeleteBrand(int id)
        {
            brandRepository.DeleteBrand(id);
        }

        public bool Exists(int id)
        {
            return brandRepository.Exists(id);
        }

        public List<Brand> GetAll()
        {
            return brandRepository.GetAll();
        }

        public Brand GetBrand(int id)
        {
            return brandRepository.GetBrand(id);
        }

        public Brand UpdateBrand(Brand brand)
        {
            return brandRepository.UpdateBrand(brand);
        }
    }
}

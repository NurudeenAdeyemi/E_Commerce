using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Repository
{
    public interface IBrandRepository
    {
        public List<Brand> GetAll();

        public Brand GetBrand(int id);

        public Brand AddBrand(Brand brand);

        public Brand UpdateBrand(Brand brand);

        public void DeleteBrand(int id);

        public bool Exists(int id);
    }
}

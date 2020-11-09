using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Service
{
    public interface ISubCategoryBrandService
    {
        public List<SubCategoryBrand> GetAll();

        public SubCategoryBrand GetSubCategoryBrand(int id);

        public SubCategoryBrand AddSubCategoryBrand(SubCategoryBrand subCategoryBrand);

        public SubCategoryBrand UpdateSubCategoryBrand(SubCategoryBrand subCategoryBrand);

        public void DeleteSubCategoryBrand(int id);

        public bool Exists(int id);
    }
}

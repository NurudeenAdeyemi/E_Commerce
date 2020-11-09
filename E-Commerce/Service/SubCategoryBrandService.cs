using E_Commerce.Models;
using E_Commerce.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Service
{
    public class SubCategoryBrandService : ISubCategoryBrandService
    {
        private readonly ISubCategoryBrandRepository subCategoryBrandRepository;

        public SubCategoryBrandService (ISubCategoryBrandRepository subCategoryBrandRepository)
        {
            this.subCategoryBrandRepository = subCategoryBrandRepository;
        }

        public SubCategoryBrand AddSubCategoryBrand(SubCategoryBrand subCategoryBrand)
        {
            return subCategoryBrandRepository.AddSubCategoryBrand(subCategoryBrand);
        }

        public void DeleteSubCategoryBrand(int id)
        {
            subCategoryBrandRepository.DeleteSubCategoryBrand(id);
        }

        public bool Exists(int id)
        {
            return subCategoryBrandRepository.Exists(id);
        }

        public List<SubCategoryBrand> GetAll()
        {
            return subCategoryBrandRepository.GetAll();
        }

        public SubCategoryBrand GetSubCategoryBrand(int id)
        {
            return subCategoryBrandRepository.GetSubCategoryBrand(id);
        }

        public SubCategoryBrand UpdateSubCategoryBrand(SubCategoryBrand subCategoryBrand)
        {
            return subCategoryBrandRepository.UpdateSubCategoryBrand(subCategoryBrand);
        }
    }
}

using E_Commerce.Models;
using E_Commerce.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Service
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly ISubCategoryRepository subCategoryRepository;

        public SubCategoryService (ISubCategoryRepository subCategoryRepository)
        {
            this.subCategoryRepository = subCategoryRepository;
        }

        public SubCategory AddSubCategory(SubCategory subCategory)
        {
            return subCategoryRepository.AddSubCategory(subCategory);
        }

        public void DeleteSubCategory(int id)
        {
            subCategoryRepository.DeleteSubCategory(id);
        }

        public bool Exists(int id)
        {
            return subCategoryRepository.Exists(id);
        }

        public List<SubCategory> GetAll()
        {
            return subCategoryRepository.GetAll();
        }

        public SubCategory GetSubCategory(int id)
        {
            return subCategoryRepository.GetSubCategory(id);
        }

        public SubCategory UpdateSubCategory(SubCategory subCategory)
        {
            return subCategoryRepository.UpdateSubCategory(subCategory);
        }
    }
}

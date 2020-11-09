using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Repository
{
    public interface ISubCategoryRepository
    {
        public List<SubCategory> GetAll();

        public SubCategory GetSubCategory(int id);

        public SubCategory AddSubCategory(SubCategory subCategory);

        public SubCategory UpdateSubCategory(SubCategory subCategory);

        public void DeleteSubCategory(int id);

        public bool Exists(int id);
    }
}

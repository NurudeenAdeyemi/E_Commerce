using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Repository
{
    public interface ICategoryRepository
    {
        public List<Category> GetAll();

        public Category GetCategory(int id);

        public Category AddCategory(Category category);

        public Category UpdateCategory(Category category);

        public void DeleteCategory(int id);

        public bool Exists(int id);
    }
}

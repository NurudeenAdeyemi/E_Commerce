using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Repository
{
    public class ProductImageRepsitory : IProductImageRepository
    {
        private readonly ECommerceContext _dbContext;

        public ProductImageRepsitory (ECommerceContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ProductImage AddProductImage(ProductImage productImage)
        {
            _dbContext.ProductImages.Add(productImage);
            _dbContext.SaveChanges();
            return productImage;
        }

        public void DeleteProductImage(int id)
        {
            var productImage = GetProductImage(id);

            if (productImage != null)
            {
                _dbContext.ProductImages.Remove(productImage);
                _dbContext.SaveChanges();
            }
        }

        public bool Exists(int id)
        {
            return _dbContext.ProductImages.Any(e => e.Id == id);
        }

        public List<ProductImage> GetAll()
        {
            return _dbContext.ProductImages.ToList();
        }

        public ProductImage GetProductImage(int id)
        {
            return _dbContext.ProductImages.Find(id);
        }

        public ProductImage UpdateProductImage(ProductImage productImage)
        {
            _dbContext.ProductImages.Update(productImage);
            _dbContext.SaveChanges();
            return productImage;
        }
    }
}

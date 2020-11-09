using E_Commerce.Models;
using E_Commerce.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Service
{
    public class ProductImageService : IProductImageService
    {
        private readonly IProductImageRepository productImageRepository;

        public ProductImageService (IProductImageRepository productImageRepository)
        {
            this.productImageRepository = productImageRepository;
        }

        public ProductImage AddProductImage(ProductImage productImage)
        {
            return productImageRepository.AddProductImage(productImage);
        }

        public void DeleteProductImage(int id)
        {
            productImageRepository.DeleteProductImage(id);
        }

        public bool Exists(int id)
        {
            return productImageRepository.Exists(id);
        }

        public List<ProductImage> GetAll()
        {
            return productImageRepository.GetAll();
        }

        public ProductImage GetProductImage(int id)
        {
            return productImageRepository.GetProductImage(id);
        }

        public ProductImage UpdateProductImage(ProductImage productImage)
        {
            return productImageRepository.UpdateProductImage(productImage);
        }
    }
}

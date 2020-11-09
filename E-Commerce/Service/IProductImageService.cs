using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Service
{
    interface IProductImageService
    {
        public List<ProductImage> GetAll();

        public ProductImage GetProductImage(int id);

        public ProductImage AddProductImage(ProductImage productImage);

        public ProductImage UpdateProductImage(ProductImage productImage);

        public void DeleteProductImage(int id);

        public bool Exists(int id);
    }
}

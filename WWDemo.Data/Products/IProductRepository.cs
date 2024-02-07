﻿using WWDemo.Models;

namespace WWDemo.Data.Products
{
    public interface IProductRepository
    {
        IQueryable<Product> GetAllProductsQuerable();

        Task<Product?> GetProductById(Guid productId);

        Task<Product?> AddProduct(Product product);

        Task<Product?> UpdateProduct(Product product);
    }
}

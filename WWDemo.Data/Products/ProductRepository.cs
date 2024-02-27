﻿using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using WWDemo.Models;

namespace WWDemo.Data.Products
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApiDbContext _apiDbContext;

        public ProductRepository(ApiDbContext apiDbContext)
        {
            _apiDbContext = apiDbContext;
        }

        public Task<List<Product?>> GetAllProducts()
        {
            return Task.Run(() => GetQueryable().ToList());
        }

        public Task<Product?> GetProductById(Guid productId)
        {
            return GetQueryable().FirstOrDefaultAsync(x => x!.Id == productId);
        }

        public async Task<Product?> AddProduct(Product product)
        {
            var result = _apiDbContext.Products?.Add(product)!;

            await _apiDbContext.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<Product?> UpdateProduct(Product product)
        {
            var result = _apiDbContext.Products?.Update(product)!;

            await _apiDbContext.SaveChangesAsync();

            return result.Entity;
        }

        private IQueryable<Product?> GetQueryable()
        {
            var products = _apiDbContext.Products;

            return products;
        }

        public async Task<Product?> GetProductBySerialNumber(string serialNumber)
        {

            var product = await GetQueryable().Where(s => s!.SerialNumber == serialNumber).FirstOrDefaultAsync();

            return product;
        }

        public async Task<Product?> GetProductByName(string name)
        {
            var product = await GetQueryable().Where(s => s.Name.Contains(name)).FirstOrDefaultAsync();
            return product;
        }
    }
}

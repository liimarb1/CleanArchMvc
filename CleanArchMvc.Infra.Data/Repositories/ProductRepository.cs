using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;
using CleanArchMvc.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Infra.Data.Repositories
{

    public class ProductRepository : IProductCategory
    {
        ApplicationDbContext _productContext;
        public ProductRepository(ApplicationDbContext context)
        {
            _productContext = context;
        }

        public async Task<Product> CreateAsync(Product product)
        {
            _productContext.Products.Add(product);
            await _productContext.SaveChangesAsync();
            return product;
           
        }

        public async Task<Product> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetProductAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetProductCategoryAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}

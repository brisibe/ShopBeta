using Microsoft.EntityFrameworkCore;
using ShopBeta.Core.DTO.Response;
using ShopBeta.Core.Interfaces;
using ShopBeta.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBeta.Infrastructure.Repository
{
    public class ProductsRepository : RepositoryBase<Products>, IProductsRepository
    {
        public ProductsRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }





        public async Task<IEnumerable<Products>> GetAllProductsAsync(bool trackChanges) =>
            await FindAll(trackChanges)
                .OrderBy(c => c.ProductsId)
                .ToListAsync();



        public async Task<IEnumerable<Products>> GetAllProductsWithReviewsAsync(bool trackChanges) =>
           await FindAll(trackChanges).Include(a => a.reviews)
               .OrderBy(c => c.ProductsId)
               .ToListAsync();



        public async Task<Products> GetProductAsync(int productId, bool trackChanges) => 
             await FindByCondition(c => c.ProductsId.Equals(productId), trackChanges).Include(a => a.reviews)
             .FirstOrDefaultAsync();


        public void CreateProduct(Products product) =>
            Create(product);

        public void DeleteProduct(Products product)=>       
            Delete(product);
    }
}

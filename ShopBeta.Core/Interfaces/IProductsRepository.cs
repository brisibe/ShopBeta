using ShopBeta.Core.DTO.Response;
using ShopBeta.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopBeta.Core.Interfaces
{
   public interface IProductsRepository
    {
        Task<IEnumerable<Products>> GetAllProductsAsync(bool trackChanges);
        Task<IEnumerable<Products>> GetAllProductsWithReviewsAsync(bool trackChanges);
        Task<Products> GetProductAsync(int productId, bool trackChanges);
        void CreateProduct(Products product);
        void DeleteProduct(Products product);
    }
}

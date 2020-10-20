using Microsoft.EntityFrameworkCore;
using ShopBeta.Core.Interfaces;
using ShopBeta.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBeta.Infrastructure.Repository
{
   public class ReviewsRepository : RepositoryBase<Reviews>, IReviewsRepository
    {
        public ReviewsRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
        public void CreateReview(Reviews review) =>
            Create(review);


        public void DeleteReview(Reviews review) =>
            Delete(review);
       

        public async Task<IEnumerable<Reviews>> GetReviews(int productId, bool trackChanges)=>
        
            await FindByCondition(c => c.ProductId.Equals(productId), trackChanges)
                .OrderBy(c => c.date)
                .ToListAsync();
        
    }
}

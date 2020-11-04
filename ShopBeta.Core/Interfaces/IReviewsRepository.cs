using ShopBeta.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBeta.Core.Interfaces
{
    public interface IReviewsRepository
    {
        Task<IEnumerable<Reviews>> GetReviews(int productId, bool trackChanges);
        Task<Reviews> GetReview(int productId, int reviewId, bool trackChanges);
        void CreateReview(Reviews review);
        void DeleteReview(Reviews review);
    }
}

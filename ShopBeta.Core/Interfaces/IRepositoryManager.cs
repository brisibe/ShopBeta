using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopBeta.Core.Interfaces
{
    public interface IRepositoryManager
    {
        IProductsRepository Products { get; }
        IReviewsRepository Reviews { get; }
        Task SaveAsync();
    }
}

using ShopBeta.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopBeta.Infrastructure.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private IProductsRepository _productsRepository;
        private IReviewsRepository _reviewsRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }


        public IProductsRepository Products
        {
            get
            {
                if (_productsRepository == null) _productsRepository = new ProductsRepository(_repositoryContext);
                return _productsRepository;
            }
        }

        public IReviewsRepository Reviews {

            get
            {
                if (_reviewsRepository == null) _reviewsRepository = new ReviewsRepository(_repositoryContext);
                return _reviewsRepository;
            }
        }

        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
      
    }
}

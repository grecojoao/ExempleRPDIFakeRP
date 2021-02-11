using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Exemple.Entities;

namespace Exemple.Repositories
{
    public class ProductFakeRepository : IProductRepository
    {
        public Task AddAssync(Product product, CancellationToken cancellationToken = default)
        {
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Product>> GetAsync(CancellationToken cancellationToken = default)
        {
            return Task.FromResult((IEnumerable<Product>)new List<Product> { new Product { Code = "7700K", Description = "Core i7" } });
        }

        public Task SaveAsync(CancellationToken cancellationToken = default)
        {
            return Task.CompletedTask;
        }
    }
}
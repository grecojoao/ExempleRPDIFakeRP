using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Exemple.Entities;

namespace Exemple.Repositories
{
    public interface IProductRepository
    {
        Task AddAssync(Product product, CancellationToken cancellationToken = default);
        Task<IEnumerable<Product>> GetAsync(CancellationToken cancellationToken = default);
        Task SaveAsync(CancellationToken cancellationToken = default);
    }
}
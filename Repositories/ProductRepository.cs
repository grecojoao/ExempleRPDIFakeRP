using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Exemple.Data;
using Exemple.Entities;
using Microsoft.EntityFrameworkCore;

namespace Exemple.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context) =>
            _context = context;

        public async Task AddAssync(Product product, CancellationToken cancellationToken = default)
        {
            await _context.Products.AddAsync(product, cancellationToken);
        }

        public async Task<IEnumerable<Product>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await _context.Products.ToArrayAsync(cancellationToken);
        }

        public async Task SaveAsync(CancellationToken cancellationToken = default)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
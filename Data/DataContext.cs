using Exemple.Entities;
using Microsoft.EntityFrameworkCore;

namespace Exemple.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}
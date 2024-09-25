using Estudo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Estudo.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Produto> Produto { get; set; }
    }
}

using Estudo.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Estudo.Api.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Movie> Movie { get; set; }
    }
}

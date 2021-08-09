using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data
{
    public class NewsContext : DbContext
    {
        public DbSet<News> News { get; set; }

        public NewsContext(DbContextOptions<NewsContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }
}

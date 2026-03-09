using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<BrandModel> Brands { get; set; }
        public DbSet<BeerModel> Beers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BrandModel>().ToTable("Brand");
            modelBuilder.Entity<BeerModel>().ToTable("Beer");
        }
    }
}

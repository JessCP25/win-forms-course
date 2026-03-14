using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<BrandModel> Brands { get; set; }
        public DbSet<BeerModel> Beers { get; set; }
        public DbSet<SaleModel> Sales { get; set; }
        public DbSet<ConceptModel> Concepts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BrandModel>().ToTable("Brand");
            modelBuilder.Entity<BeerModel>().ToTable("Beer");
            modelBuilder.Entity<SaleModel>().ToTable("Sale");
            modelBuilder.Entity<ConceptModel>().ToTable("Concept");

            modelBuilder.Entity<SaleModel>()
                .HasMany(s => s.Concepts)
                .WithOne()
                .HasForeignKey(c => c.IdSale)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

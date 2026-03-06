using ApplicationBusiness;
using Data;
using Entities;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository
{
    public class BrandRepository : IRepository<Brand>
    {

        private readonly AppDbContext _dbContext;
        public BrandRepository(AppDbContext dbContext) { 
            _dbContext = dbContext;
        }
        public async Task AddAsync(Brand item)
        {
            var brandModel = new BrandModel
            {
                Id = item.Id,
                Name = item.Name,
            };
            await _dbContext.AddAsync(brandModel);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Brand>> GetAllAsync()
         => await _dbContext.Brands.Select(b => new Brand
         {
             Id = b.Id,
             Name = b.Name,
         }).ToListAsync();

        public async Task<Brand> GetByIdAsync(int id)
        {
            var brandModel = await _dbContext.Brands.FindAsync(id);
            return new Brand
            {
                Id = brandModel.Id,
                Name = brandModel.Name,
            };
        }

        public async Task EditAsync(Brand brand)
        {
            var model = await _dbContext.Brands.FindAsync(brand.id);

            model.Name = brand.Name;

            _dbContext.Entry(model).State = EntityState.Modified;

            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var model = await _dbContext.Brands.FindAsync(id);

            _dbContext.Brands.Remove(model);

            await _dbContext.SaveChangesAsync();
        }
    }
}

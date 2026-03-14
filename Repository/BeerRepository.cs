using ApplicationBusiness;
using Data;
using Entities;
using Microsoft.EntityFrameworkCore;
using Models;
using Repository.AdditionalDataClass;

namespace Repository
{
    public class BeerRepository: IRepositoryAdditionalData<Beer, BeerAdditionalData>
    {
        private readonly AppDbContext _dbContext;
        public BeerRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Beer beer, BeerAdditionalData beerAdditionalData)
        {
            var beerModel = new BeerModel()
            {
                Name = beer.Name,
                BrandId = beer.BrandId,
                Alcohol = beer.Alcohol,
                Description = beerAdditionalData.Description,
            };
            await _dbContext.AddAsync(beerModel);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<IEnumerable<Beer>> GetAllAsync()
            => await _dbContext.Beers.Select(b => new Beer()
            {
                Id = b.Id,
                Name = b.Name,
                BrandId = b.BrandId,
                Alcohol = b.Alcohol,
            }).ToListAsync();
        public async Task<(Beer, BeerAdditionalData)> GetByIdAsync(int id)
        {
            var beerModel = await _dbContext.Beers.FindAsync(id);
            var beer = new Beer()
            {
                Id = beerModel.Id,
                Name = beerModel.Name,
                BrandId = beerModel.BrandId,
                Alcohol = beerModel.Alcohol,
            };
            var beerAdditionalData = new BeerAdditionalData()
            {
                Description = beerModel.Description
            };

            return (beer, beerAdditionalData);
        }
        public async Task EditAsync(Beer beer, BeerAdditionalData beerAdditionalData)
        {
            var beerModel = await _dbContext.Beers.FindAsync(beer.Id);

            beerModel.Name = beer.Name;
            beerModel.BrandId = beer.BrandId;
            beerModel.Alcohol = beer.Alcohol;
            beerModel.Description = beerAdditionalData.Description;

            _dbContext.Entry(beerModel).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var beerModel = await _dbContext.Beers.FindAsync(id);

            _dbContext.Beers.Remove(beerModel);
            await _dbContext.SaveChangesAsync();
        }
    }
}

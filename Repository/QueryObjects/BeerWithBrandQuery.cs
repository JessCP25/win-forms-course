using Data;
using Microsoft.EntityFrameworkCore;
using Repository.QueryResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.QueryObjects
{
    public class BeerWithBrandQuery
    {
        private readonly AppDbContext _appDbContext;
        public BeerWithBrandQuery(AppDbContext appDbContext )
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<BeerWithBrandResult>> GetAsync()
            => await _appDbContext.Beers.Join(
                _appDbContext.Brands,
                beer => beer.BrandId,
                brand => brand.Id,
                (beer, brand) => new BeerWithBrandResult()
                {
                    Id = beer.Id,
                    Name = beer.Name,
                    Brand = brand.Name
                }).ToListAsync();
    }
}

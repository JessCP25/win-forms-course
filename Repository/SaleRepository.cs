using ApplicationBusiness;
using Data;
using Entities;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SaleRepository: IRepositorySimple<Sale>
    {
        private readonly AppDbContext _dbContext;
        public SaleRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Sale sale)
        {
            var saleModel = new SaleModel();
            saleModel.Total = sale.Total;
            saleModel.CreationDate = sale.Date;
            saleModel.Concepts = sale.Concepts.Select(c => new ConceptModel
            {
                UnitPrice = c.UnitPrice,
                IdBeer = c.IdBeer,
                Quantity = c.Quantity,
            }).ToList();

            await _dbContext.Sales.AddAsync(saleModel);
            await _dbContext.SaveChangesAsync();
        }
    }
}

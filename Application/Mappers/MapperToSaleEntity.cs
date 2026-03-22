using ApplicationBusiness.DTOs;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBusiness.Mappers
{
    public class MapperToSaleEntity: IMapper<SaleDTO, Sale>
    {
        public Sale Map(SaleDTO saleDTO)
        {
            var concepts = new List<Concept>();

            foreach (var conceptDTO in saleDTO.Concepts)
            {
                concepts.Add(new Concept(conceptDTO.Quantity, conceptDTO.IdBeer, conceptDTO.UnitPrice));
            }

            return new Sale(DateTime.Now, concepts);
        }
    }
}

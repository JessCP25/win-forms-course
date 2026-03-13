using ApplicationBusiness.DTOs;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBusiness.Mappers
{
    public class MapperToBeerEntity: IMapper<BeerDTO, Beer>
    {
        public Beer Map(BeerDTO beerDTO)
        {
            return new Beer()
            {
                Id = beerDTO.Id,
                Name = beerDTO.Name,
                BrandId = beerDTO.BrandId,
                Alcohol = beerDTO.Alcohol,
            };
        }
    }
}

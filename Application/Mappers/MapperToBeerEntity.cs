using ApplicationBusiness.DTOs;
using Entities;

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
                Price = beerDTO.Price,
            };
        }
    }
}

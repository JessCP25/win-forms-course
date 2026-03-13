using ApplicationBusiness;
using ApplicationBusiness.DTOs;
using Repository.AdditionalDataClass;

namespace Repository.Mappers
{
    public class MapperToBeerAdditionalData: IMapper<BeerDTO, BeerAdditionalData>
    {
        public BeerAdditionalData Map(BeerDTO beerDTO)
        {
            return new BeerAdditionalData()
            {
                Description = beerDTO.Description,
            };
        }
    }
}

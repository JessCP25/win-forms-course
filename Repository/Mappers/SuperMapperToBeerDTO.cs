using ApplicationBusiness;
using ApplicationBusiness.DTOs;
using Entities;
using Repository.AdditionalDataClass;

namespace Repository.Mappers
{
    public class SuperMapperToBeerDTO: ISuperMapper<Beer,BeerAdditionalData, BeerDTO>
    {
        public BeerDTO Map(Beer beer, BeerAdditionalData beerAdditionalData) 
        {
            return new BeerDTO()
            {
                Id = beer.Id,
                Name = beer.Name,
                BrandId = beer.BrandId,
                Alcohol = beer.Alcohol,
                Description = beerAdditionalData.Description,
            };
        }
    }
}

using ApplicationBusiness.DTOs;
using Entities;

namespace ApplicationBusiness
{
    public class AddBeer<TAdditionalData>
    {
        private readonly IRepositoryAdditionalData<Beer, TAdditionalData> _repositoryBeer;
        private readonly IMapper<BeerDTO,Beer > _mapperEntity;
        private readonly IMapper<BeerDTO, TAdditionalData> _mapperAdditionalData;
        public AddBeer(IRepositoryAdditionalData<Beer, TAdditionalData> repositoryBeer, IMapper<BeerDTO, Beer> mapperEntity, IMapper<BeerDTO, TAdditionalData> mapperAdditionalData)
        {
            _repositoryBeer = repositoryBeer;
            _mapperEntity = mapperEntity;
            _mapperAdditionalData = mapperAdditionalData;
        }

        public async Task ExecuteAsync(BeerDTO beerDTO)
        {
            var beer = _mapperEntity.Map(beerDTO);
            var beerAdditionalData = _mapperAdditionalData.Map(beerDTO);

            if (string.IsNullOrEmpty(beer.Name))
            {
                throw new Exception("El nombre de la cerveza es obligatorio");
            }

            await _repositoryBeer.AddAsync(beer, beerAdditionalData);
        }
    }

}

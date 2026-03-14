using ApplicationBusiness.DTOs;
using Entities;

namespace ApplicationBusiness
{
    public class EditBeer<TAdditionalData>
    {
        private readonly IRepositoryAdditionalData<Beer, TAdditionalData> _repository;
        private readonly IMapper<BeerDTO, Beer> _mapperEntity;
        private readonly IMapper<BeerDTO, TAdditionalData> _mapperAdditionalData;
        public EditBeer(IRepositoryAdditionalData<Beer, TAdditionalData> repository,
            IMapper<BeerDTO, Beer> mapperEntity, IMapper<BeerDTO, TAdditionalData> mapperAdditionalData)
        {
            _repository = repository;
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

            if ((await _repository.GetByIdAsync(beer.Id)).Item1 == null) 
            {
                throw new Exception("Cerveza no existente");
            }

            await _repository.EditAsync(beer, beerAdditionalData);
        }
    }
}

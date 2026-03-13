using ApplicationBusiness.DTOs;
using Entities;

namespace ApplicationBusiness
{
    public class GetBeerById<TAdditionalData>
    {
        private readonly IRepositoryAdditionalData<Beer, TAdditionalData> _beerRepository;
        private readonly ISuperMapper<Beer, TAdditionalData, BeerDTO> _superMapper;

        public GetBeerById(IRepositoryAdditionalData<Beer, TAdditionalData> beerRepository, ISuperMapper<Beer, TAdditionalData, BeerDTO> superMapper)
        {
            _beerRepository = beerRepository;
            _superMapper = superMapper;
        }

        public async Task<BeerDTO> ExecuteAsync(int id)
        {
            var (beer, beerAdditionalData) = await _beerRepository.GetByIdAsync(id);
            var beerDTO = _superMapper.Map(beer, beerAdditionalData);

            return beerDTO;
        }
    }
}

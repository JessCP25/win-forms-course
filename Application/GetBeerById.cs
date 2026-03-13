using ApplicationBusiness.DTOs;
using Entities;

namespace ApplicationBusiness
{
    public class GetBeerById<TAdditionalData>
    {
        private readonly IRepositoryAdditionalData<Beer, TAdditionalData> _beerRepository;

        public GetBeerById(IRepositoryAdditionalData<Beer, TAdditionalData> beerRepository)
        {
            _beerRepository = beerRepository;
        }

        public async Task<BeerDTO> ExecuteAsync(int id)
        {
            var (beer, beerAdditionalData) = await _beerRepository.GetByIdAsync(id);
        }
    }
}

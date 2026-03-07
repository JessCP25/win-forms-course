using Entities;

namespace ApplicationBusiness
{
    public class AddBeer
    {
        private readonly IRepository<Beer> _repositoryBeer;
        public AddBeer(IRepository<Beer> repositoryBeer)
        {
            _repositoryBeer = repositoryBeer;
        }

        public async Task ExecuteAsync(Beer beer)
        {
            if (string.IsNullOrEmpty(beer.Name))
            {
                throw new Exception("El nombre de la cerveza es obligatorio");
            }

            await _repositoryBeer.AddAsync(beer);
        }
    }

}

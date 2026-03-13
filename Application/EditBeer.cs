using Entities;

namespace ApplicationBusiness
{
    public class EditBeer<TAdditionalData>
    {
        private readonly IRepositoryAdditionalData<Beer, TAdditionalData> _repository;
        public EditBeer(IRepositoryAdditionalData<Beer, TAdditionalData> repository)
        {
            _repository = repository;
        }

        public async Task ExecuteAsync(Beer beer)
        {
            if (string.IsNullOrEmpty(beer.Name)) 
            {
                throw new Exception("El nombre de la cerveza es obligatorio");
            }

            if ((await _repository.GetByIdAsync(beer.Id)).Item1 == null) 
            {
                throw new Exception("Cerveza no existente");
            }

            await _repository.EditAsync(beer);
        }
    }
}

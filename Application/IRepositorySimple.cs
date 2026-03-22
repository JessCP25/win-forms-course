
namespace ApplicationBusiness
{
    public interface IRepositorySimple<T>
    {
        Task AddAsync(T item);
        Task<IEnumerable<T>> GetAllAsync();
    }
}

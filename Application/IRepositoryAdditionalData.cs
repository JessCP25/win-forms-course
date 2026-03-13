using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBusiness
{
    public interface IRepositoryAdditionalData<T, TAdditionalData>
    {
        Task<(T, TAdditionalData)> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T item, TAdditionalData additionalData);
        Task EditAsync(T item);
        Task DeleteAsync(int id);
    }
}

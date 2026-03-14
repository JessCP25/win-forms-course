using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBusiness
{
    public interface IRepositorySimple<T>
    {
        Task AddAsync(T item);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JADASystec.DataAccess.Contracts.Repositories.Base
{
    public interface IBaseRepository<T>where T : class
    {
        Task<bool> ExistAsync(object id);
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetAsync(object id);
        Task<int> DeleteAsync(object id, object IdUsuario);

        Task<T> UpdateAsync(T element, object IdUsuario);
        Task<T> AddAsync(T element, object IdUsuario);
        Task<int> NameExistAsync(string name);
    }
}

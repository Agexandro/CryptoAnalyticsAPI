using System.Collections.Generic;
using System.Threading.Tasks;

namespace CryptoAnalytics.Api.Repositories.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task<List<T>> GetAsyncAll();
        Task<T> GetAsync(int id);
        Task<long> CreateAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(int id);
    }
}
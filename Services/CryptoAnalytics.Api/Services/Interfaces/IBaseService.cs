using System.Collections.Generic;
using System.Threading.Tasks;

namespace CryptoAnalytics.Api.Services.Interfaces
{
    public interface IBaseService<T>
    {
        Task<List<T>> GetAsyncAll();
        Task<T> GetAsync(int id);
        Task<long> CreateAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(int id);
    }
}
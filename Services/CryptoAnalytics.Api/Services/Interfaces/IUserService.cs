using CryptoAnalytics.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace CryptoAnalytics.Api.Services.Interfaces
{
    public interface IUserService : IBaseService<User>
    {
        Task<List<User>> GetAsyncAll();
        Task<User> GetAsync(int id);
        Task<long> CreateAsync(User entity);
        Task<bool> UpdateAsync(User entity);
        Task<bool> DeleteAsync(int id);
    }
}
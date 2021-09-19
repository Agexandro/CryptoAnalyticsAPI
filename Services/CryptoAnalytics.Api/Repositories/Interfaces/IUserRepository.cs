using CryptoAnalytics.Entities;
using CryptoAnalytics.Entities.Dto;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CryptoAnalytics.Api.Repositories.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
     Task<UserDto> GetUserDtoAsync(int id);
     Task<UserDto> GetUserDtoAsync(string loginName);
    }
}
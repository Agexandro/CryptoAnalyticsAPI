using CryptoAnalytics.Entities;
using CryptoAnalytics.Entities.Dto;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace CryptoAnalytics.Api.Services.Interfaces
{
    public interface IUserService : IBaseService<User>
    {
        Task<UserDto> GetUserDtoAsync(int id);
        Task<UserDto> GetUserDtoAsync(string loginName);
        Task<List<UserDto>> GetParamUserDtoAsync(string loginName, string profileId);

    }
}
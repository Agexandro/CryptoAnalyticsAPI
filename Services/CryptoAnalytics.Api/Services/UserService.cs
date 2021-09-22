using CryptoAnalytics.Api.Services.Interfaces;
using CryptoAnalytics.Api.Repositories.Interfaces;
using CryptoAnalytics.Entities;
using CryptoAnalytics.Entities.Dto;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace CryptoAnalytics.Api.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<UserDto>> GetParamUserDtoAsync(string firstName, string profileId)
        {
            var users = await _repository.GetParamUserDtoAsync(firstName, profileId);
            return users;
        }

        public async Task<UserDto> GetUserDtoAsync(int id)
        {
            var user = await _repository.GetUserDtoAsync(id);
            return user;
        }

        public async Task<UserDto> GetUserDtoAsync(string loginName)
        {
            var user = await _repository.GetUserDtoAsync(loginName);
            return user;
        }

        public async Task<List<User>> GetAsyncAll()
        {
            var users = await _repository.GetAsyncAll();
            return users;
        }

        public async Task<User> GetAsync(int id)
        {
            var user = await _repository.GetAsync(id);
            return user;
        }
        public async Task<long> CreateAsync(User user)
        {
            var id = await _repository.CreateAsync(user);
            return id;
        }
        public async Task<bool> UpdateAsync(User user)
        {
            var updated = await _repository.UpdateAsync(user);
            return updated;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var result = await _repository.DeleteAsync(id);
            return result;
        }
    }
}
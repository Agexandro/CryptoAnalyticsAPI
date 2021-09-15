using MySqlConnector;
using Dapper;
using Dapper.Contrib.Extensions;
using CryptoAnalytics.Entities;
using CryptoAnalytics.Api.Repositories.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;
using CryptoAnalytics.Api.Data.Interfaces;
using CryptoAnalytics.Api.Data;

namespace CryptoAnalytics.Api.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IData _data;

        public UserRepository(IData data)
        {
            _data = data;
        }

        public async Task<List<User>> GetAsyncAll()
        {
            var users = (List<User>)await _data.Connection.GetAllAsync<User>();
            return users;
        }

        public async Task<User> GetAsync(int id)
        {
            var user = await _data.Connection.GetAsync<User>(id);
            return user;
        }
        public async Task<long> CreateAsync(User user)
        {
            var id = await _data.Connection.InsertAsync<User>(user);
            user.Id = (int)id;
            return id;
        }
        public async Task<bool> UpdateAsync(User user)
        {
            var updated = await _data.Connection.UpdateAsync<User>(user);
            return updated;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var user = new User { Id = id };
            var result = await _data.Connection.DeleteAsync<User>(user);
            return result;
        }
    }
}
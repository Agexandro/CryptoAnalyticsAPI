using MySqlConnector;
using Dapper;
using Dapper.Contrib.Extensions;
using CryptoAnalytics.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using CryptoAnalytics.Api.Repositories.Interfaces;
using CryptoAnalytics.Api.Data.Interfaces;
using System.Linq;

namespace CryptoAnalytics.Api.Repositories
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly IData _data;

        public ProfileRepository(IData data)
        {

            _data = data;
        }

        public async Task<List<Profile>> GetAsyncAll()
        {
            var profiles = await _data.Connection.GetAllAsync<Profile>();
            return profiles.ToList();
        }
        public async Task<Profile> GetAsync(int id)
        {
            var profile = await _data.Connection.GetAsync<Profile>(id);
            return profile;
        }
        public async Task<long> CreateAsync(Profile profile)
        {
            return 0;
        }
        public async Task<bool> UpdateAsync(Profile profile)
        {
            return true;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            return true;
        }
    }
}
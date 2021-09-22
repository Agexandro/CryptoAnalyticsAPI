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
            var id = await _data.Connection.InsertAsync<Profile>(profile);
            return (int)id;
        }
        public async Task<bool> UpdateAsync(Profile profile)
        {
            var update = await _data.Connection.UpdateAsync<Profile>(profile);
            return update;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var profile = new Profile { Id = id };
            var result = await _data.Connection.DeleteAsync<Profile>(profile);
            return result;
        }

        public async Task<int> ValidateDelete(int id)
        {
            const string sql =
            @"select count(*) 
            from Profiles p join Users u 
            where p.id = @ProfileId and p.id =  u.profileId;";

            var result = await _data.Connection.QueryAsync<int>(sql, new { ProfileId = id });
            return result.ToList().FirstOrDefault();
        }
    }
}
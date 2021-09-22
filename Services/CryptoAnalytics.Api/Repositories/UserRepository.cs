using MySqlConnector;
using Dapper;
using Dapper.Contrib.Extensions;
using CryptoAnalytics.Entities;
using CryptoAnalytics.Entities.Dto;
using CryptoAnalytics.Api.Repositories.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;
using CryptoAnalytics.Api.Data.Interfaces;
using CryptoAnalytics.Api.Data;
using System.Linq;

namespace CryptoAnalytics.Api.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IData _data;

        public UserRepository(IData data)
        {
            _data = data;
        }

        public async Task<List<UserDto>> GetParamUserDtoAsync(string firstName, string profileId)
        {
            string sql =
            @"SELECT
            u.Id,
            u.FirstName,
            u.LastName,
            u.LoginName,
            u.ProfileId,
            p.Id,
            p.Name,
            p.Description
            FROM
            Users u
            INNER JOIN Profiles p
            ON u.ProfileId = p.Id
            WHERE true
            ";

            if (firstName.Length > 0)
            {
                sql += " and u.FirstName = @FirstName";
            }
            if (profileId.Length > 0)
            {
                sql += " and u.ProfileId = @ProfileId";
            }

            var users = await _data.Connection.QueryAsync<User, Profile, UserDto>(sql, (user, profile) => new UserDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                LoginName = user.LoginName,
                ProfileId = profile.Id,
                Profile = profile
            }, new { FirstName = firstName, ProfileId = profileId }, splitOn: "ProfileId");

            return users.ToList();
        }


        public async Task<UserDto> GetUserDtoAsync(int id)
        {
            const string sql =
            @"SELECT
            u.Id,
            u.FirstName,
            u.LastName,
            u.LoginName,
            u.ProfileId,
            p.Id,
            p.Name,
            p.Description
            FROM
            Users u
            INNER JOIN Profiles p
            ON u.ProfileId = p.Id
            WHERE u.Id = @UserId;
            ";

            var users = await _data.Connection.QueryAsync<User, Profile, UserDto>(sql, (user, profile) => new UserDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                LoginName = user.LoginName,
                ProfileId = profile.Id,
                Profile = profile
            }, new { UserID = id }, splitOn: "ProfileId");

            var user = users.ToList().FirstOrDefault();


            return user;
        }

        public async Task<UserDto> GetUserDtoAsync(string loginName)
        {
            const string sql =
            @"SELECT
            u.Id,
            u.FirstName,
            u.LastName,
            u.LoginName,
            u.ProfileId,
            p.Id,
            p.Name,
            p.Description
            FROM
            Users u
            INNER JOIN Profiles p
            ON u.ProfileId = p.Id
            WHERE u.LoginName = @UserLoginName;
            ";

            var users = await _data.Connection.QueryAsync<User, Profile, UserDto>(sql, (user, profile) => new UserDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                LoginName = user.LoginName,
                ProfileId = profile.Id,
                Profile = profile
            }, new { UserLoginName = loginName }, splitOn: "ProfileId");

            var user = users.ToList().FirstOrDefault();


            return user;
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
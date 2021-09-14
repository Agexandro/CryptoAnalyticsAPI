using MySqlConnector;
using Dapper;
using Dapper.Contrib.Extensions;
using CryptoAnalytics.Entities;
using CryptoAnalytics.Api.Repositories.Interfaces;

namespace CryptoAnalytics.Api.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MySqlConnection _connection;

        public UserRepository()
        {
            _connection = new MySqlConnection("server=192.168.1.69;user=testguy;password=root;database=crypto;port=3306");
        }

        public User Get(int id)
        {
            var user = _connection.GetAsync<User>(id).Result;
            return user;
        }
        public User Create(User user)
        {
            var id = _connection.InsertAsync<User>(user).Result;
            user.Id = (int)id;
            return user;
        }
        public User Update(User user)
        {
            var updated = _connection.UpdateAsync<User>(user).Result;
            return user;
        }
        public bool Delete(int id)
        {
            var user = new User { Id = id };
            _connection.DeleteAsync<User>(user);
            return true;
        }
    }
}
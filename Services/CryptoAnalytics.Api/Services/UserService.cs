using CryptoAnalytics.Api.Services.Interfaces;
using CryptoAnalytics.Api.Repositories.Interfaces;
using CryptoAnalytics.Entities;

namespace CryptoAnalytics.Api.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository){
            _repository = repository;
        }

        public User Get(int id)
        {
            var user = _repository.Get(id);
            return user;
        }
        public User Create(User user)
        {
            _repository.Create(user);
            return user;
        }
        public User Update(User user)
        {
            _repository.Update(user);
            return user;
        }
        public bool Delete(int id)
        {
            _repository.Delete(id);
            return true;
        }
    }
}
using CryptoAnalytics.Entities;

namespace CryptoAnalytics.Api.Repositories.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User Get(int id);
        User Create(User user);
        User Update(User user);
        bool Delete(int id);
    }
}
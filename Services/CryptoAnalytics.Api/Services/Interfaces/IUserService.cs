using CryptoAnalytics.Entities;

namespace CryptoAnalytics.Api.Services.Interfaces
{
    public interface IUserService : IBaseService<User>
    {
         User Get(int id);
         User Create(User user);
         User Update(User user);
         bool Delete(int id);
    }
}
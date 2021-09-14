using System.Collections.Generic;
using System.Threading.Tasks;

namespace CryptoAnalytics.Api.Services.Interfaces
{
    public interface IBaseService<T>
    {
        T Get(int id);
        T PostUser(T entity);
        T PutUser(T entity);
        bool DeleteUser(int id);
    }
}
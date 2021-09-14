using System.Collections.Generic;
using System.Threading.Tasks;

namespace CryptoAnalytics.Api.Repositories.Interfaces
{
    public interface IBaseRepository<T>
    {
        T Get(int id);
        T Create(T entity);
        T Update(T entity);
        bool Delete(int id);
    }
}
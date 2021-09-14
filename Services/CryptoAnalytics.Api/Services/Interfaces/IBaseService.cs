using System.Collections.Generic;
using System.Threading.Tasks;

namespace CryptoAnalytics.Api.Services.Interfaces
{
    public interface IBaseService<T>
    {
        T Get(int id);
        T Create(T entity);
        T Update(T entity);
        bool Delete(int id);
    }
}
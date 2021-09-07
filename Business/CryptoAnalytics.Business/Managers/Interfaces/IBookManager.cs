using CryptoAnalytics.Entities;

namespace CryptoAnalytics.Business.Managers.Interfaces
{
    public interface IBookManager
    {
        Book GetBook(string id);
    }
}
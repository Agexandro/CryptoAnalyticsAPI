using CryptoAnalytics.Entities;

namespace CryptoAnalytics.Business.Services.Interfaces
{
    public interface IExchangeService
    {
        Book GetBook(string id);
    }
}
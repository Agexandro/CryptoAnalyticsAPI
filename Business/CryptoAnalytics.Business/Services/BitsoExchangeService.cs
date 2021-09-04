using CryptoAnalytics.Entities;
using CryptoAnalytics.Business.Services.Interfaces;

namespace CryptoAnalytics.Business.Services
{
    public class BitsoExchangeService : IExchangeService
    {
        public Book GetBook(string id)
        {
            var book = new Book();
            book.Id = id;
            book.LastPrice = "5600.0";
            return book;
        }
    }
}
using CryptoAnalytics.Entities;
using CryptoAnalytics.Business.Services.Interfaces;

namespace CryptoAnalytics.Business.Managers
{
    public class BookManager
    {
        private IExchangeService _exchangeService;
        public BookManager(IExchangeService exchangeService)
        {
            _exchangeService = exchangeService;
        }

        public Book GetBook(string id)
        {
            var book = _exchangeService.GetBook(id);
            return book;
        }
    }
}
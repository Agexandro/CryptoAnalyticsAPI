using System;
using CryptoAnalytics.Business.Services;
using CryptoAnalytics.Business.Managers;

namespace CryptoAnalytics.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exchange
            var exchangeService = new ExchangeService();
            var bookManager = new BookManager(exchangeService);
            Console.WriteLine(bookManager.GetBook("mx_btc").LastPrice);
            Console.WriteLine(bookManager.GetBook("mx_btc").Id);
            //Bitso Exchange
            var bitsoExchangeService = new BitsoExchangeService();
            var bookManager2 = new BookManager(bitsoExchangeService);
            Console.WriteLine(bookManager2.GetBook("usd_btc").LastPrice);
            Console.WriteLine(bookManager2.GetBook("usd_btc").Id);
        }
    }
}

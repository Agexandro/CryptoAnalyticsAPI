using System;
using CryptoAnalytics.App.Screens;
using CryptoAnalytics.Business.Services;
using CryptoAnalytics.Business.Managers;

namespace CryptoAnalytics.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var screen = new MainScreen("Main Screen");
            screen.Show();   
        }
    }
}

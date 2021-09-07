using System;

namespace CryptoAnalytics.App.Screens
{
    public class BaseScreen
    {
        protected string Title { get; private set; }

        protected BaseScreen(string title)
        {
            Title = title;
        }

        protected void PrintLine(string text)
        {
            Console.WriteLine(text);
        }

        protected void Print(string text)
        {
            Console.Write(text);
        }

        protected void PrintMarket(string text)
        {
            var title = $"****** {text} ******";
            PrintLine(title);
            PrintSymbol("*", title.Length);
        }

        protected void PrintSymbol(string text, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Print(text);
            }
        }

        protected void ClearScreen()
        {
            Console.Clear();
        }

        protected void Pause()
        {
            Console.ReadKey();
        }

        protected string Input()
        {
            return Console.ReadLine();
        }

        public virtual void Show()
        {
            PrintLine(Title);
        }
    }
}
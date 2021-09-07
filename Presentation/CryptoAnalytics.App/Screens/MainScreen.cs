namespace CryptoAnalytics.App.Screens
{
    public class MainScreen : BaseScreen
    {
        public MainScreen(string title = "") : base(title)
        {

        }

        public override void Show()
        {
            PrintLine(Title);
        }
    }
}
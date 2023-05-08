using Season3_Day2_2.UI.Views;
using System.Windows;

namespace Season3_Day2_2
{
    internal class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            PracticeWIndow window = new();
            window.Show();
        }
    }
}
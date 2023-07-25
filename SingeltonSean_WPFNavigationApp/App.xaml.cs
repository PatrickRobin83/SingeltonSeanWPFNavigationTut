using System.Windows;
using SingeltonSean_WPFNavigationApp.Stores;
using SingeltonSean_WPFNavigationApp.ViewModels;

namespace SingeltonSean_WPFNavigationApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private NavigationStore navigationStore = new NavigationStore();

        #region Overrides of Application

        protected override void OnStartup(StartupEventArgs e)
        {
            navigationStore.CurrentViewModel = new AccountViewModel(navigationStore);
            
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }

        #endregion
    }
}
using Microsoft.Extensions.DependencyInjection;
using Radzen;
using System.Configuration;
using System.Data;
using System.Windows;

namespace ExpenseCatch
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var services = new ServiceCollection();

            // web view stuff
            services.AddWpfBlazorWebView();

            // ui
            services.AddRadzenComponents();
            
            // setup di
            // services.AddSingleton<>();
            // ...
            
            Resources.Add("mainServices", services.BuildServiceProvider());
        }
    }

}

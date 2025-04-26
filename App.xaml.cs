using Microsoft.Extensions.DependencyInjection;
using Radzen;
using System.Windows;
using ExpenseCatch.Services;

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
            services.AddBlazorWebViewDeveloperTools();

            // ui
            services.AddRadzenComponents();
            
            // setup di
            services.AddSingleton<DbContextService>();
            
            Resources.Add("mainServices", services.BuildServiceProvider());
        }
    }

}

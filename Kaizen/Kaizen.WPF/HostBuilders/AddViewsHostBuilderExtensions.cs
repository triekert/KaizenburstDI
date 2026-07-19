using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Kaiizen.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kaiizen.WPF.HostBuilders
{
    public static class AddViewsHostBuilderExtensions
    {
        public static IHostBuilder AddViews(this IHostBuilder host)
        {
            host.ConfigureServices(services =>
            {
                services.AddSingleton<MainWindow>(s => new MainWindow(s.GetRequiredService<MainViewModel>()));
            });

            return host;
        }
    }
}

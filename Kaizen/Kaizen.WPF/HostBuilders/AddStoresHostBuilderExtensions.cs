using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Kaiizen.WPF.State.Accounts;
using Kaiizen.WPF.State.Assets;
using Kaiizen.WPF.State.Authenticators;
using Kaiizen.WPF.State.Navigators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kaiizen.WPF.HostBuilders
{
    public static class AddStoresHostBuilderExtensions
    {
        public static IHostBuilder AddStores(this IHostBuilder host)
        {
            host.ConfigureServices(services =>
            {
                services.AddSingleton<INavigator, Navigator>();
                services.AddSingleton<IAuthenticator, Authenticator>();
                services.AddSingleton<IAccountStore, AccountStore>();
                services.AddSingleton<AssetStore>();
            });

            return host;
        }
    }
}

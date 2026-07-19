using Microsoft.AspNet.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Kaiizen.Domain.Models;
using Kaiizen.Domain.Services;
using Kaiizen.Domain.Services.AuthenticationServices;
using Kaiizen.Domain.Services.TransactionServices;
using Kaiizen.EntityFramework.Services;
using Kaiizen.FinancialModelingPrepAPI.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kaiizen.WPF.HostBuilders
{
    public static class AddServicesHostBuilderExtensions
    {
        public static IHostBuilder AddServices(this IHostBuilder host)
        {
            host.ConfigureServices(services =>
            {
                services.AddSingleton<IPasswordHasher, PasswordHasher>();

                services.AddSingleton<IAuthenticationService, AuthenticationService>();
                services.AddSingleton<IDataService<Account>, AccountDataService>();
                services.AddSingleton<IAccountService, AccountDataService>();
                services.AddSingleton<IStockPriceService, StockPriceService>();
                services.AddSingleton<IBuyStockService, BuyStockService>();
                services.AddSingleton<ISellStockService, SellStockService>();
                services.AddSingleton<IMajorIndexService, MajorIndexService>();
            });

            return host;
        }
    }
}

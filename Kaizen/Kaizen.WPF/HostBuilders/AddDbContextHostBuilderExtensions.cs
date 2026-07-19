using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Kaiizen.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kaiizen.WPF.HostBuilders
{
    public static class AddDbContextHostBuilderExtensions
    {
        public static IHostBuilder AddDbContext(this IHostBuilder host)
        {
            host.ConfigureServices((context, services) =>
            {
                string connectionString = context.Configuration.GetConnectionString("sqlite");
                Action<DbContextOptionsBuilder> configureDbContext = o => o.UseSqlite(connectionString);

                services.AddDbContext<KaiizenDbContext>(configureDbContext);
                services.AddSingleton<KaiizenDbContextFactory>(new KaiizenDbContextFactory(configureDbContext));
            });

            return host;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kaiizen.EntityFramework
{
    public class KaiizenDbContextFactory
    {
        private readonly Action<DbContextOptionsBuilder> _configureDbContext;

        public KaiizenDbContextFactory(Action<DbContextOptionsBuilder> configureDbContext)
        {
            _configureDbContext = configureDbContext;
        }

        public KaiizenDbContext CreateDbContext()
        {
            DbContextOptionsBuilder<KaiizenDbContext> options = new DbContextOptionsBuilder<KaiizenDbContext>();

            _configureDbContext(options);

            return new KaiizenDbContext(options.Options);
        }
    }
}

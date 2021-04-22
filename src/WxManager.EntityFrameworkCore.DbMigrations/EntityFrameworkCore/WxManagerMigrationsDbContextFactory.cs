using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace WxManager.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class WxManagerMigrationsDbContextFactory : IDesignTimeDbContextFactory<WxManagerMigrationsDbContext>
    {
        public WxManagerMigrationsDbContext CreateDbContext(string[] args)
        {
            WxManagerEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<WxManagerMigrationsDbContext>()
               .UseMySql(configuration.GetConnectionString("Default"), new MySqlServerVersion(new Version(5, 7)), mySqlOptions => mySqlOptions
                           .CharSetBehavior(CharSetBehavior.NeverAppend));

            return new WxManagerMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../WxManager.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}

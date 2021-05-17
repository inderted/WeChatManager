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

            var EnableDb = configuration["ConnectionStrings:Enable"];

            var builder = new DbContextOptionsBuilder<WxManagerMigrationsDbContext>();

            #region OldMysql

            //Console.WriteLine($"url:{Path.Combine(Directory.GetCurrentDirectory(), "../WxManager.DbMigrator/")}");
            //Console.WriteLine($"configuration.GetConnectionString('Default'):{configuration.GetConnectionString("Default")}");
            //builder.UseMySql(configuration.GetConnectionString("Default"), new MySqlServerVersion(new Version(5, 7)), mySqlOptions => mySqlOptions
            //               .CharSetBehavior(CharSetBehavior.NeverAppend));

            #endregion

            //Console.WriteLine($"EnableDb:{EnableDb}");
            //Console.WriteLine($"configuration.GetConnectionString(EnableDb):{configuration.GetConnectionString(EnableDb)}");
            switch (EnableDb)
            {
                case "MySql":
                    builder.UseMySql(configuration.GetConnectionString(EnableDb),
                        new MySqlServerVersion(new Version(5, 7)),
                        mySqlOptions => mySqlOptions.CharSetBehavior(CharSetBehavior.NeverAppend));
                    break;

                case "SqlServer":
                    builder.UseSqlServer(configuration.GetConnectionString(EnableDb));
                    break;

                case "PostgreSql":
                    builder.UseNpgsql(configuration.GetConnectionString(EnableDb));
                    break;

                case "Sqlite":
                    builder.UseSqlite(configuration.GetConnectionString(EnableDb));
                    break;
            }

            return new WxManagerMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}

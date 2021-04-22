using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WxManager.Data;
using Volo.Abp.DependencyInjection;

namespace WxManager.EntityFrameworkCore
{
    public class EntityFrameworkCoreWxManagerDbSchemaMigrator
        : IWxManagerDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreWxManagerDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the WxManagerMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<WxManagerMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
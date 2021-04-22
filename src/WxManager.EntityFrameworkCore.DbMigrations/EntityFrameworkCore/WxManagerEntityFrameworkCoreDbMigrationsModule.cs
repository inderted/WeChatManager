using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace WxManager.EntityFrameworkCore
{
    [DependsOn(
        typeof(WxManagerEntityFrameworkCoreModule)
        )]
    public class WxManagerEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<WxManagerMigrationsDbContext>();
        }
    }
}

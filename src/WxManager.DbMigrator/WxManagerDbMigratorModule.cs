using WxManager.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace WxManager.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(WxManagerEntityFrameworkCoreDbMigrationsModule),
        typeof(WxManagerApplicationContractsModule)
        )]
    public class WxManagerDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}

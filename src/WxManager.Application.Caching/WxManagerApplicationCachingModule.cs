using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Caching;
using Volo.Abp.Modularity;
using WxManager;
using WxManager.Domain.AppSettings;

namespace WxManager.Application.Caching
{
    [DependsOn(
        typeof(AbpCachingModule),
        typeof(WxManagerDomainModule)
    )]
    public class WxManagerApplicationCachingModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            if (AppSettings.Caching.IsOpen)
            {
                context.Services.AddStackExchangeRedisCache(options =>
                {
                    options.Configuration = AppSettings.Caching.RedisConnectionString;
                });

                context.Services.AddSingleton<IRedisConnectionWrapper, RedisConnectionWrapper>();
                context.Services.AddScoped<IStaticCacheManager, RedisCacheManager>();
            }
        }
    }
}
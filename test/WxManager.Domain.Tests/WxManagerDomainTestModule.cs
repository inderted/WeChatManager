using WxManager.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace WxManager
{
    [DependsOn(
        typeof(WxManagerEntityFrameworkCoreTestModule)
        )]
    public class WxManagerDomainTestModule : AbpModule
    {

    }
}
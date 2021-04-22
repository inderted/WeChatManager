using Volo.Abp.Modularity;

namespace WxManager
{
    [DependsOn(
        typeof(WxManagerApplicationModule),
        typeof(WxManagerDomainTestModule)
        )]
    public class WxManagerApplicationTestModule : AbpModule
    {

    }
}
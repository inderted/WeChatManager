using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace WxManager.Web
{
    [Dependency(ReplaceServices = true)]
    public class WxManagerBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "WxManager";
    }
}

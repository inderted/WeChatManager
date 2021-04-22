using WxManager.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace WxManager.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class WxManagerController : AbpController
    {
        protected WxManagerController()
        {
            LocalizationResource = typeof(WxManagerResource);
        }
    }
}
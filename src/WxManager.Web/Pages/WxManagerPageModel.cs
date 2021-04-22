using WxManager.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace WxManager.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class WxManagerPageModel : AbpPageModel
    {
        protected WxManagerPageModel()
        {
            LocalizationResourceType = typeof(WxManagerResource);
        }
    }
}
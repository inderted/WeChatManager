using System;
using System.Collections.Generic;
using System.Text;
using WxManager.Localization;
using Volo.Abp.Application.Services;

namespace WxManager
{
    /* Inherit your application services from this class.
     */
    public abstract class WxManagerAppService : ApplicationService
    {
        protected WxManagerAppService()
        {
            LocalizationResource = typeof(WxManagerResource);
        }
    }
}

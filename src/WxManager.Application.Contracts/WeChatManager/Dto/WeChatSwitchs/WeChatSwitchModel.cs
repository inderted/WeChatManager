using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace WxManager.Application.Contracts.WeChatManager.WeChatSwitchs
{
    public class WeChatSwitchModel
    {
        public WeChatSwitchModel()
        {
            AvailableWeChatConfigIds = new List<SelectListItem>();
        }

        /// <summary>
        /// 选择公众号
        /// </summary>
        public int SelWeChatConfigId { get; set; }

        /// <summary>
        /// 可用公众号
        /// </summary>
        public IList<SelectListItem> AvailableWeChatConfigIds { get; set; }
    }
}

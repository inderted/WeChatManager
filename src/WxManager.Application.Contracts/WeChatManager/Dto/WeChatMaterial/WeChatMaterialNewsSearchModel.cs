using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace WxManager.Application.Contracts.WeChatManager.WeChatMaterial
{
    public class WeChatMaterialNewsSearchModel : BaseSearchModel
    {
        public IList<int> WeChatMaterialNewsStatusIds { get; set; } = new List<int>();
        public int WeChatConfigId { get; set; }
        public IList<SelectListItem> WeChatConfigItems { get; set; } = new List<SelectListItem>();
        public IList<SelectListItem> WeChatMaterialNewsStatusItems { get; set; } = new List<SelectListItem>();
    }
}

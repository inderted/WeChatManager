using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace WxManager.Application.Contracts.WeChatManager.WeChatAutoReplys
{
    public class WeChatAutoReplySearchModel
    {
        public string SearchName { get; set; }

        public string SearchFullKeyword { get; set; }

        public string SearchHalfKeyword { get; set; }

        public int? SearchReplyType { get; set; }

        public IList<SelectListItem> SearchReplayTypes { get; set; } = new List<SelectListItem>();
    }
}
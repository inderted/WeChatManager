using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace WxManager.Application.Contracts.WeChatManager.WeChatQrCodes
{
    public class WeChatQrCodeListModel : EntityDto<int>
    {
        public WeChatQrCodeListModel()
        {
            AvailableTypes = new List<SelectListItem>();
        }
        public string SearchName { get; set; }
        public string SearchType { get; set; }

        public IList<SelectListItem> AvailableTypes { get; set; }
    }
}

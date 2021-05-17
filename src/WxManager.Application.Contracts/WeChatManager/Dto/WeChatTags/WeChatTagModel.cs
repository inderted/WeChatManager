using System;
using Volo.Abp.Application.Dtos;

namespace WxManager.Application.Contracts.WeChatManager.WeChatTags
{
    public class WeChatTagModel : EntityDto<int>
    {
        /// <summary>
        /// 标签Id
        /// </summary>
        public int WeChatId { get; set; }
        /// <summary>
        /// 标签名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///  //此标签下粉丝数
        /// </summary>
        public int Count { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}

using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;
using WxManager.WeChatManager.WeChatUsers;

namespace WxManager.WeChatManager.WeChatTags
{
    public class WeChatTag : Entity<int>
    {

        /// <summary>
        /// 关联公众号配置Id
        /// </summary>
        public int WeChatConfigId { get; set; }

        /// <summary>
        /// 微信标签Id
        /// </summary>
        public int WeChatId { get; set; }

        public string Name { get; set; }

        public int Count { get; set; }

        public DateTime? CreatedOnUtc { get; set; }

        public DateTime? UpdatedOnUtc { get; set; }

        /// <summary>
        /// 用户被打上的标签ID列表
        /// </summary>
        public virtual ICollection<WeChatUserTag> WeChatUserTags { get; set; } = new List<WeChatUserTag>();

    }
}

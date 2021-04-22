using Volo.Abp.Domain.Entities;
using WxManager.WeChatManager.WeChatTags;

namespace WxManager.WeChatManager.WeChatUsers
{
    public class WeChatUserTag : Entity<int>
    {
        public int WeChatUserId { get; set; }

        public virtual WeChatUser WeChatUser { get; set; }

        public int WeChatTagId { get; set; }

        public virtual WeChatTag WeChatTag { get; set; }
    }
}

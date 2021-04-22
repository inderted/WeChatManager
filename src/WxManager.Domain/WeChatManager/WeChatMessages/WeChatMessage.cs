using System;
using Volo.Abp.Domain.Entities;
using WxManager.WeChatManager.WeChatConfigs;
using WxManager.WeChatManager.WeChatUsers;

namespace WxManager.WeChatManager.WeChatMessages
{
    /// <summary>
    /// 微信消息
    /// </summary>
    public class WeChatMessage : Entity<int>
    {
        /// <summary>
        /// 关联公众号配置Id
        /// </summary>
        public int WeChatConfigId { get; set; }

        /// <summary>
        /// 用户OpenId
        /// </summary>
        /// <returns></returns>
        public string UserOpenId { get; set; }

        /// <summary>
        /// 关联用户
        /// </summary>
        /// <returns></returns>
        public int WeChatUserId { get; set; }

        public int? CustomerId { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        /// <returns></returns>
        public string Content { get; set; }

        /// <summary>
        /// 是否已读
        /// </summary>
        /// <returns></returns>
        public bool IsRead { get; set; }

        /// <summary>
        /// 消息类型 0接收，1发送
        /// </summary>
        /// <returns></returns>
        public int MsgType { get; set; }

        public ContentType ContentType
        {
            get => (ContentType)this.ContentTypeId;
            set => this.ContentTypeId = (int)value;
        }

        /// <summary>
        /// 内容类型
        /// </summary>
        public int ContentTypeId { get; set; }

        /// <summary>
        /// 发送时间
        /// </summary>
        /// <returns></returns>
        public DateTime SendTimeUtc { get; set; }

        public virtual WeChatUser WeChatUser { get; set; }

        public virtual WeChatConfig WeChatConfig { get; set; }


    }
}
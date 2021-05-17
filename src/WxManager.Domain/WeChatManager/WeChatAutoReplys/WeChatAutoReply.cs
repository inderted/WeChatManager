using System;
using System.ComponentModel;
using Volo.Abp.Domain.Entities;
using WxManager.WeChatManager.WeChatConfigs;

namespace WxManager.WeChatManager.WeChatAutoReplys
{
    public class WeChatAutoReply : Entity<int>
    {
        /// <summary>
        /// 规则名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 半匹配 关键词 ,分割
        /// </summary>
        public string HalfKeyWords { get; set; }

        /// <summary>
        /// 全匹配 关键词 ,分割
        /// </summary>
        public string FullKeyWords { get; set; }

        public int ReplayTypeId { get; set; }

        /// <summary>
        /// 回复类型
        /// </summary>
        public ReplyType ReplyType
        {
            get => (ReplyType)ReplayTypeId;
            set => ReplayTypeId = (int)value;
        }

        /// <summary>
        /// 回复内容
        /// </summary>
        public string Content { get; set; }

        public bool IsSubscribe { get; set; }

        public bool IsDefault { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public DateTime UpdatedOnUtc { get; set; }

        public int WeChatConfigId { get; set; }

        public bool IsPublish { get; set; }

        public virtual WeChatConfig WeChatConfig { get; set; }
    }
}
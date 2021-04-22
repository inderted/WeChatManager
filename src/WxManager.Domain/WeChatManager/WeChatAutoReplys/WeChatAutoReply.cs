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

    /// <summary>
    /// 回复类型
    /// </summary>
    public enum ReplyType
    {
        /// <summary>
        /// 文本
        /// </summary>
        [Description("文本")]
        Text = 0,

        /// <summary>
        /// 图文消息
        /// </summary>
        [Description("图文消息")]
        News = 1,

        /// <summary>
        /// 图片
        /// </summary>
        [Description("图片")]
        Image = 2,

        /// <summary>
        /// 音频
        /// </summary>
        [Description("音频")]
        Voice = 3,

        /// <summary>
        /// 视频
        /// </summary>
        [Description("视频")]
        Video = 4
    }
}
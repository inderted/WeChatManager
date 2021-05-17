using System;
using Volo.Abp.Application.Dtos;
using WxManager.WeChatManager.WeChatAutoReplys;

namespace WxManager.Application.Contracts.WeChatManager.WeChatAutoReplys
{
    public class WeChatAutoReplyModel : EntityDto<int>
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

        /// <summary>
        /// 关注时回复
        /// </summary>
        public bool IsSubscribe { get; set; }

        /// <summary>
        /// 默认回复
        /// </summary>
        public bool IsDefault { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public bool IsPublish { get; set; }
    }
}
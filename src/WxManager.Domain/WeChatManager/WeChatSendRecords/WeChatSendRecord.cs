using System;
using WxManager.WeChatManager.WeChatConfigs;
using Senparc.Weixin.MP;
using Volo.Abp.Domain.Entities;

namespace WxManager.WeChatManager.WeChatSendRecords
{
    /// <summary>
    /// 微信群发记录
    /// </summary>
    public class WeChatSendRecord : Entity<int>
    {
        /// <summary>
        /// 关联公众号配置Id
        /// </summary>
        public int WeChatConfigId { get; set; }

        /// <summary>
        /// 消息Id
        /// </summary>
        public string MsgId { get; set; }

        /// <summary>
        /// 数据Id
        /// </summary>
        public string MsgDataId { get; set; }

        /// <summary>
        /// 媒体文件类型
        /// </summary>
        public int MsgTypeId { get; set; }

        public string MediaId { get; set; }

        public int? WeChatTagId { get; set; }

        /// <summary>
        /// 媒体文件类型，分别有图片（image）、语音（voice）、视频（video）和缩略图（thumb），图文消息为news
        /// </summary>
        public GroupMessageType MsgType
        {
            get => (GroupMessageType)this.MsgTypeId;
            set => this.MsgTypeId = (int)value;
        }

        /// <summary>
        /// 状态
        /// </summary>
        public string MsgStatus { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 创建
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }

        public virtual WeChatConfig WeChatConfig { get; set; }
    }
}
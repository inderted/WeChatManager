using Senparc.Weixin.MP;
using System;
using Volo.Abp.Application.Dtos;

namespace WxManager.Application.Contracts.WeChatManager.WeChatSendRecords
{
    public class WeChatSendRecordModel : EntityDto<int>
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
        /// 群发类型
        /// </summary>
        public int MsgTypeId { get; set; }

        /// <summary>
        /// 群发标签组Id
        /// </summary>
        public int? WeChatTagId { get; set; }

        /// <summary>
        /// 群发标签组
        /// </summary>
        public string WeChatTagName { get; set; }

        /// <summary>
        /// 素材Id
        /// </summary>
        public string MediaId { get; set; }

        /// <summary>
        /// 群发文件类型，分别有图片（image）、语音（voice）、视频（video）和缩略图（thumb），图文消息为news
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
        public DateTime CreatedOn { get; set; }
    }
}

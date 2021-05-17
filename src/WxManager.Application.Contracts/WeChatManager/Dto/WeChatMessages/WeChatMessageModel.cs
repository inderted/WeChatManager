using System;
using Volo.Abp.Application.Dtos;

namespace WxManager.Application.Contracts.WeChatManager.WeChatMessages
{
    public class WeChatMessageModel : EntityDto<int>
    {
        /// <summary>
        /// 关联用户
        /// </summary>
        /// <returns></returns>
        public int WeChatUserId { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        /// <returns></returns>
        public string Content { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        public int ContentType { get; set; }

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

        /// <summary>
        /// 发送时间
        /// </summary>
        /// <returns></returns>
        public DateTime? SendTime { get; set; }

        /// <summary>
        /// 发送人
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// 发送人Id
        /// </summary>
        public int? CustomerId { get; set; }
    }
}
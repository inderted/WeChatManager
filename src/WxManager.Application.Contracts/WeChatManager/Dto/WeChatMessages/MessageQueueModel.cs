using System;
using WxManager.Application.Contracts.WeChatManager.WeChatConfigs;
using WxManager.Domain.Shared.WeChatMessages;

namespace WxManager.Application.Contracts.WeChatManager.WeChatMessages
{
    public class MessageQueueModel
    {
        public WeChatConfigModel WeChatConfigModel { get; set; }
        public string FromOpenId { get; set; }
        public ContentType ContentType { get; set; }
        public string Content { get; set; }
        public DateTime CreateTime { get; set; }

    }
}

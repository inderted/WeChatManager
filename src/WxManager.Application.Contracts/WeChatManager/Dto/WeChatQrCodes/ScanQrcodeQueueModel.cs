using WxManager.Application.Contracts.WeChatManager.WeChatConfigs;
using System;

namespace WxManager.Application.Contracts.WeChatManager.WeChatQrCodes
{
    public class ScanQrCodeQueueModel
    {
        public WeChatConfigModel WeChatConfigModel { get; set; }
        public string FromOpenId { get; set; }
        public string EventKey { get; set; }
        public string Ticket { get; set; }
        public DateTime CreateTime { get; set; }
    }
}

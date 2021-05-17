using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WxManager.Application.Contracts.WeChatManager.WeChatConfigs;

namespace WxManager.Application.Contracts.WeChatManager.Subscribes
{
    public class SubscribeModel
    {
        public WeChatConfigModel WeChatConfigModel { get; set; }
        public string FromOpenId { get; set; }
        public string EventKey { get; set; }
        public string Ticket { get; set; }
        public DateTime CreateTime { get; set; }
        public bool Subscribe { get; set; }
    }
}

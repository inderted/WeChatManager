using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WxManager.Application.Caching
{
    public class ModelCacheEventConsumer
    {
        #region Constants

        /// <summary>
        /// 插件缓存头部
        /// </summary>
        public const string WeChatPattern_KEY = "WxManager.WeChat";

        /// <summary>
        /// 公众号配置 Id键
        /// </summary>
        public const string WeChatConfigId_Key = "WxManager.WeChat:WeChatConfig:{0}";
        /// <summary>
        /// 公众号配置 模式
        /// </summary>
        public const string WeChatConfigPattern_Key = "WxManager.WeChat:WeChatConfig";

        /// <summary>
        /// 过期时间
        /// </summary>
        public const int WeChatSetting_KEY_CacheTime = 3600;

        /// <summary>
        /// 标签列表
        /// </summary>
        public const string WeChatTagList_Key = "WxManager.WeChat:Tag:List";
        /// <summary>
        /// 标签微信Id
        /// </summary>
        public const string WeChatTagId_Key = "WxManager.WeChat:Tag:WeChatId:{0}";
        /// <summary>
        /// 标签模糊搜索
        /// </summary>
        public const string WeChatTagName_Key = "WxManager.WeChat:Tag:{0}:Name:{1}";
        /// <summary>
        /// 标签微信 模式
        /// </summary>
        public const string WeChatTagPattern_Key = "WxManager.WeChat:Tag";

        /// <summary>
        /// 二维码类型
        /// </summary>
        public const string WeChatQrcodeType_Key = "WxManager.WeChat:QrCode:Type:All";

        /// <summary>
        /// 二维码Id
        /// </summary>
        public const string WeChatQrcodeId_Key = "WxManager.WeChat:QrCode:Id:{0}";

        /// <summary>
        /// 二维码Ticket
        /// </summary>
        public const string WeChatQrCodeTicket_Key = "WxManager.WeChat:QrCode:Ticket:{0}";

        /// <summary>
        /// 二维码 模式
        /// </summary>
        public const string WeChatQrCodePattern_Key = "WxManager.WeChat:QrCode";

        /// <summary>
        /// 未读数
        /// </summary>
        public const string WeChatMessageNoReadCount = "WxManager.WeChat:Message:NoReadCount:{0}";
        /// <summary>
        /// 消息
        /// </summary>
        public const string WeChatUserLastMessage = "WxManager.WeChat:Message:Last:UserId:{0}-{1}-{2}-{3}";
        /// <summary>
        /// 消息
        /// </summary>
        public const string WeChatUserBeforeMessage = "WxManager.WeChat:Message:Before:UserId:{0}-{1}-{2}-{3}";
        /// <summary>
        /// 信息 模式
        /// </summary>
        public const string WeChatMessagePattern_Key = "WxManager.WeChat:Message";

        /// <summary>
        /// 消息通知 模式
        /// </summary>
        public const string WeChatMessageNotifyPattern_Key = "WxManager.WeChat:Notify";

        /// <summary>
        /// 启用通知
        /// </summary>
        public const string WeChatMessageNotifyEnableList_Key = "WxManager.WeChat:Notify:EnbaleList";

        /// <summary>
        /// 消息通知 Id
        /// </summary>
        public const string WeChatMessageNotifyId_Key = "WxManager.WeChat:Notify:Id:{0}";

        /// <summary>
        /// 消息通知 Id
        /// </summary>
        public const string WeChatMessageNotifyCustomerId_Key = "WxManager.WeChat:Notify:CustomerId:{0}-{1}";

        /// <summary>
        /// 消息通知 用户
        /// </summary>
        public const string WeChatMessageNitifyUser_Key = "WxManager.WeChat:Notified:Id:{0}-{1}";

        #endregion
    }
}

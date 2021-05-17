using Volo.Abp.Application.Dtos;

namespace WxManager.Application.Contracts.WeChatManager.WeChatMessages
{
    /// <summary>
    /// 消息通知
    /// </summary>
    public class WeChatMessageNotifyModel : EntityDto<int>
    {
        /// <summary>
        /// 关联公众号
        /// </summary>
        public int WeChatConfigId { get; set; }

        /// <summary>
        /// 关联用户
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// 通知微信账号
        /// </summary>
        public string CustomerOpenId { get; set; }

        /// <summary>
        /// 关联粉丝
        /// </summary>
        public int WeChatUserId { get; set; }

        /// <summary>
        /// 通知间隔 minute
        /// </summary>
        public int Interval { get; set; }

        /// <summary>
        /// 启用
        /// </summary>
        public bool Enable { get; set; }
    }
}

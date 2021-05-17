using Senparc.Weixin;
using Volo.Abp.Application.Dtos;

namespace WxManager.Application.Contracts.WeChatManager.WeChatConfigs
{
    public class WeChatConfigModel : EntityDto<int>
    {
        /// <summary>
        /// 公众号名称
        /// </summary>
        public virtual string WeChatName { get; set; }

        /// <summary>
        /// 公众号Id
        /// </summary>
        public virtual string WeChatId { get; set; }

        /// <summary>
        /// 公众号Token
        /// </summary>
        public virtual string WeChatToken { get; set; }

        /// <summary>
        /// 公众号appID
        /// </summary>
        public virtual string WeChatAppId { get; set; }

        /// <summary>
        /// 公众号appsecret
        /// </summary>
        public virtual string WeChatAppSecret { get; set; }

        /// <summary>
        /// 公众号EncodingAESKey
        /// </summary>
        public virtual string EncodingAESKey { get; set; }

        /// <summary>
        /// 数据语言版本
        /// </summary>
        public virtual Language Language { get; set; }

        /// <summary>
        /// 微信认证Url
        /// </summary>
        public virtual string WeChatVerifyUrl { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public virtual bool Deleted { get; set; }

        public virtual string NotifyTemplateId { get; set; }
    }
}

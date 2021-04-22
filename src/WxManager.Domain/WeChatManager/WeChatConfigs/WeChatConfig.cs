using Senparc.Weixin;
using Volo.Abp.Domain.Entities;

namespace WxManager.WeChatManager.WeChatConfigs
{
    public class WeChatConfig : Entity<int>
    {
        /// <summary>
        /// 公众号名称
        /// </summary>
        public string WeChatName { get; set; }

        /// <summary>
        /// 公众号Id
        /// </summary>
        public string WeChatId { get; set; }

        /// <summary>
        /// 公众号Token
        /// </summary>
        public string WeChatToken { get; set; }

        /// <summary>
        /// 公众号AppId
        /// </summary>
        public string WeChatAppId { get; set; }

        /// <summary>
        /// 公众号appsecret
        /// </summary>
        public string WeChatAppSecret { get; set; }

        /// <summary>
        /// 公众号EncodingAESKey
        /// </summary>
        public string EncodingAESKey { get; set; }

        /// <summary>
        /// 数据语言版本
        /// </summary>
        public Language Language
        {
            get => (Language)this.LanguageId;
            set => this.LanguageId = (int)value;
        }

        /// <summary>
        /// 数据语言版本Id
        /// </summary>
        public int LanguageId { get; set; }

        public bool Deleted { get; set; }

        /// <summary>
        /// 消息通知模板Id
        /// </summary>
        public string NotifyTemplateId { get; set; }
    }
}

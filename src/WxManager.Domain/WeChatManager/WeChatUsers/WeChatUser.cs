using WxManager.WeChatManager.WeChatMessages;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace WxManager.WeChatManager.WeChatUsers
{
    public class WeChatUser : Entity<int>
    {
        public int CustomerId { get; set; }

        /// <summary>
        /// 关联公众号配置Id
        /// </summary>
        public int WeChatConfigId { get; set; }

        public DateTime? CreatedOnUtc { get; set; }

        public DateTime? UpdatedOnUtc { get; set; }

        public string OpenId { get; set; }

        public bool Subscribe { get; set; }

        /// <summary>
        /// 用户的昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 用户的性别，值为1时是男性，值为2时是女性，值为0时是未知
        /// </summary>
        public int Sex { get; set; }

        /// <summary>
        /// 用户所在城市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 用户所在国家
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// 用户所在省份
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// 用户的语言，简体中文为zh_CN
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// 用户头像，最后一个数值代表正方形头像大小（有0、46、64、96、132数值可选，0代表640*640正方形头像），用户没有头像时该项为空。若用户更换头像，原有头像URL将失效。
        /// </summary>
        public string HeadImgUrl { get; set; }

        /// <summary>
        /// 首次关注时间
        /// </summary>
        public DateTime? FirstSubscribeTimeUtc { get; set; }

        /// <summary>
        /// 用户关注时间。如果用户曾多次关注，则取最后关注时间
        /// </summary>
        public DateTime? SubscribeTimeUtc { get; set; }

        /// <summary>
        /// 用户取消关注时间
        /// </summary>
        public DateTime? UnSubscribeTimeUtc { get; set; }

        /// <summary>
        /// 只有在用户将公众号绑定到微信开放平台帐号后，才会出现该字段。
        /// </summary>
        public string UnionId { get; set; }

        /// <summary>
        /// 公众号运营者对粉丝的备注，公众号运营者可在微信公众平台用户管理界面对粉丝添加备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 用户所在的分组ID（兼容旧的用户分组接口）
        /// </summary>
        public int WeChatGroupId { get; set; }

        /// <summary>
        /// 是否拉黑
        /// </summary>
        public bool? BlackUser { get; set; }

        /// <summary>
        /// 用户被打上的标签ID列表
        /// </summary>
        public virtual ICollection<WeChatUserTag> WeChatUserTags { get; set; } = new List<WeChatUserTag>();

        public virtual ICollection<WeChatMessage> WeChatMessages { get; set; } = new List<WeChatMessage>();
    }
}
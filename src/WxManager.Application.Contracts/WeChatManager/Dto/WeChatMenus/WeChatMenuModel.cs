using System;
using Volo.Abp.Application.Dtos;

namespace WxManager.Application.Contracts.WeChatManager.WeChatMenus
{
    /// <summary>
    /// 自定义菜单
    /// </summary>
    public class WeChatMenuModel : EntityDto<int>
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 是否个性化菜单
        /// </summary>
        public bool PersonaliseMenu { get; set; }
        /// <summary>
        /// 微信个性菜单Id
        /// </summary>
        public string MenuId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdatedOn { get; set; }

        /// <summary>
        /// 菜单内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 是否发布
        /// </summary>
        public bool Published { get; set; }

        /// <summary>
        /// 微信配置Id
        /// </summary>
        public bool WeChatConfigId { get; set; }
    }
}

using System;
using Volo.Abp.Domain.Entities;
using WxManager.WeChatManager.WeChatConfigs;

namespace WxManager.WeChatManager.WeChatMenus
{
    public class WeChatMenu : Entity<int>
    {

        //private ICollection<WeChatMenuItem> _weChatMenuItems;

        /// <summary>
        /// 关联公众号配置Id
        /// </summary>
        public int WeChatConfigId { get; set; }

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

        public bool Published { get; set; }

        public string Content { get; set; }

        ///// <summary>
        ///// 关联菜单  最多3个
        ///// </summary>
        //public virtual ICollection<WeChatMenuItem> WeChatMenuItems
        //{
        //    get => _weChatMenuItems ?? (_weChatMenuItems = new List<WeChatMenuItem>());
        //    set => _weChatMenuItems = value;
        //}

        public DateTime CreatedOnUtc { get; set; }

        public DateTime UpdatedOnUtc { get; set; }

        public virtual WeChatConfig WeChatConfig { get; set; }
    }
}

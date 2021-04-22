using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace WxManager.WeChatManager.WeChatMaterial
{
    /// <summary>
    /// 图文版本
    /// </summary>
    public class WeChatMaterialNewsVersion : Entity<int>
    {
        /// <summary>
        /// 版本号
        /// </summary>
        public int VersionNumber { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }
        /// <summary>
        /// 图文Id
        /// </summary>
        public int WeChatMaterialNewsId { get; set; }
        /// <summary>
        /// 图文
        /// </summary>
        public virtual WeChatMaterialNews WeChatMaterialNews { get; set; }

        public virtual ICollection<WeChatMaterialNewsArticle> WeChatMaterialNewsArticles { get; set; } =
            new List<WeChatMaterialNewsArticle>();
    }
}

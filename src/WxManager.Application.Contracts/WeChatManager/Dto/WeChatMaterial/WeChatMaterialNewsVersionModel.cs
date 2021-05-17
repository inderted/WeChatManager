using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace WxManager.Application.Contracts.WeChatManager.WeChatMaterial
{
    /// <summary>
    /// 图文版本
    /// </summary>
    public class WeChatMaterialNewsVersionModel : EntityDto<int>
    {
        /// <summary>
        /// 版本号
        /// </summary>
        public int VersionNumber { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// 图文Id
        /// </summary>
        public int WeChatMaterialNewsId { get; set; }
        /// <summary>
        /// 文章
        /// </summary>
        public IList<WeChatMaterialNewsArticleModel> WeChatMaterialNewsArticles { get; set; } =
            new List<WeChatMaterialNewsArticleModel>();
    }
}

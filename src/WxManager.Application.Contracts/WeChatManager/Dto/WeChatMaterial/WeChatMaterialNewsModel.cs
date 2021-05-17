using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;
using WxManager.WeChatManager.WeChatMaterial;

namespace WxManager.Application.Contracts.WeChatManager.WeChatMaterial
{
    /// <summary>
    /// 图文
    /// </summary>
    public class WeChatMaterialNewsModel : EntityDto<int>
    {
        /// <summary>
        /// 图文状态
        /// </summary>
        public int WeChatMaterialNewsStatusId { get; set; }
        /// <summary>
        /// 图文状态
        /// </summary>
        public WeChatMaterialNewsStatus WeChatMaterialNewsStatus
        {
            get => (WeChatMaterialNewsStatus)WeChatMaterialNewsStatusId;
            set => WeChatMaterialNewsStatusId = (int)value;
        }
        /// <summary>
        /// 关联公众号
        /// </summary>
        public int? WeChatConfigId { get; set; }

        public IList<SelectListItem> WeChatConfigItems { get; set; } = new List<SelectListItem>();
        /// <summary>
        /// 关联公众号
        /// </summary>
        public string WeChatConfigName { get; set; }
        public string WeChatMediaId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdatedOn { get; set; }
        /// <summary>
        /// 创建者
        /// </summary>
        public int CreatedById { get; set; }
        public string CreatedBy { get; set; }
        /// <summary>
        /// 更新者
        /// </summary>
        public int UpdatedById { get; set; }
        public string UpdatedBy { get; set; }
        /// <summary>
        /// 关联图文版本
        /// </summary>
        public IList<WeChatMaterialNewsVersionModel> WeChatMaterialNewsVersions { get; set; } = new List<WeChatMaterialNewsVersionModel>();
        /// <summary>
        /// 所有版本选项
        /// </summary>
        public IList<SelectListItem> WeChatMaterialNewsVersionItems { get; set; } = new List<SelectListItem>();
        /// <summary>
        /// 最新版本
        /// </summary>
        public WeChatMaterialNewsVersionModel WeChatMaterialNewsMaxVersions { get; set; }
    }


}

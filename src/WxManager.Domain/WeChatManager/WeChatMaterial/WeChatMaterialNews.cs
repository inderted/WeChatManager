using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;
using WxManager.WeChatManager.ApprovalRules;

namespace WxManager.WeChatManager.WeChatMaterial
{
    /// <summary>
    /// 图文
    /// </summary>
    public class WeChatMaterialNews : Entity<int>
    {
        /// <summary>
        /// 状态
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
        public string WeChatMediaId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdatedOnUtc { get; set; }
        /// <summary>
        /// 创建者
        /// </summary>
        public int CreatedById { get; set; }
        /// <summary>
        /// 更新者
        /// </summary>
        public int UpdatedById { get; set; }
        /// <summary>
        /// 审批规则Id
        /// </summary>
        public int? ApprovalRuleId { get; set; }

        /// <summary>
        /// 关联图文版本
        /// </summary>
        public virtual ICollection<WeChatMaterialNewsVersion> WeChatMaterialNewsVersions { get; set; } = new List<WeChatMaterialNewsVersion>();
        /// <summary>
        /// 审批规则
        /// </summary>
        public virtual ApprovalRule ApprovalRule { get; set; }
    }


}

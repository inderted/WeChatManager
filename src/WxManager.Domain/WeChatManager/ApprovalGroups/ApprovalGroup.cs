using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace WxManager.WeChatManager.ApprovalGroups
{
    public class ApprovalGroup : Entity<int>
    {
        /// <summary>
        /// 审批组名称
        /// </summary>
        public string ApprovalGroupName { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        public int CreatedById { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedTimeUtc { get; set; }

        /// <summary>
        /// 更新者
        /// </summary>
        public int UpdatedById { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdatedTimeUtc { get; set; }

        public virtual ICollection<ApprovalGroupInfo> ApprovalGroupInfos { get; set; } = new List<ApprovalGroupInfo>();
    }
}
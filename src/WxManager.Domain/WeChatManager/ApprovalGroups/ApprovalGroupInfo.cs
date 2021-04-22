using System;
using Volo.Abp.Domain.Entities;

namespace WxManager.WeChatManager.ApprovalGroups
{
    public class ApprovalGroupInfo : Entity<int>
    {
        /// <summary>
        /// 审批组Id
        /// </summary>
        public int ApprovalGroupId { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 创建者Id
        /// </summary>
        public int CreatedById { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedTimeUtc { get; set; }

        public virtual ApprovalGroup ApprovalGroup { get; set; }
    }
}

using System;
using System.ComponentModel;
using Volo.Abp.Domain.Entities;
using WxManager.WeChatManager.ApprovalRules;

namespace WxManager.WeChatManager.ApprovalDetails
{
    public class ApprovalDetail : Entity<int>
    {

        public string Name { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime? UpdateOnUtc { get; set; }

        public int CreatedByCustomerId { get; set; }
        public int ApprovalDetailStatusId { get; set; }
        public ApprovalDetailStatus ApprovalDetailStatus
        {
            get => (ApprovalDetailStatus)ApprovalDetailStatusId;
            set => ApprovalDetailStatusId = (int)value;
        }
        /// <summary>
        /// 下个审批节点名称
        /// </summary>
        public string NextApprovalDetailName { get; set; }
        /// <summary>
        /// 当前审批人
        /// </summary>
        public int? CurrentApproverId { get; set; }



        /// <summary>
        /// 所属审批组id
        /// </summary>
        public int ApprovalGroupId { get; set; }



        /// <summary>
        /// 上一审批明细id
        /// </summary>
        public int? BeforeApproverId { get; set; }


        /// <summary>
        /// 图文
        /// </summary>
        public int WeChatMaterialNewsId { get; set; }

        /// <summary>
        /// 审批规则
        /// </summary>
        public int ApprovalRuleId { get; set; }
        public virtual ApprovalRule ApprovalRule { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        public int WeChatMaterialNewsVersionId { get; set; }
        public int NodeId { get; set; }
        public string Extra { get; set; }
    }
    public enum ApprovalDetailStatus
    {
        [Description("等待审批")]
        等待审批 = 0,
        [Description("通过")]
        通过 = 1,
        [Description("驳回")]
        驳回 = 2
    }
}

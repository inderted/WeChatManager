using WxManager.WeChatManager.ApprovalDetails;
using WxManager.WeChatManager.ApprovalGroups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Volo.Abp.Domain.Entities;
using WxManager.Domain.Shared.ApprovalRules;

namespace WxManager.WeChatManager.ApprovalRules
{
    /// <summary>
    /// 审批规则
    /// </summary>
    public class ApprovalRule : Entity<int>
    {
        public virtual ICollection<ApprovalDetail> ApprovalDetails { get; set; } = new List<ApprovalDetail>();
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int ApprovalRuleStatusId { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        /// <summary>
        /// 创建者id
        /// </summary>
        public int CreatedByCustomerId { get; set; }
        public DateTime? UpdateOnUtc { get; set; }
        /// <summary>
        /// 修改者id
        /// </summary>
        public int? UpdateByCustomerId { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public int ApprovalRuleTypeId { get; set; }
        /// <summary>
        /// 规则json 
        /// [
        ///{
        ///"id":1
        ///"beforeId":1
        ///"name": "节点名称",
        ///"roleId": 1,
        ///"nextId":1
        /// }
        ///]
        /// </summary>
        public string RuleJson { get; set; }
        public ApprovalRuleType ApprovalRuleType
        {
            get => (ApprovalRuleType)ApprovalRuleTypeId;
            set => ApprovalRuleTypeId = (int)value;
        }
        public ApprovalRuleStatus ApprovalRuleStatus
        {
            get => (ApprovalRuleStatus)ApprovalRuleStatusId;
            set => ApprovalRuleStatusId = (int)value;
        }
        /// <summary>
        /// 外键
        /// </summary>
        public int ApprovalGroupId { get; set; }
        public virtual ApprovalGroup ApprovalGroup { get; set; }

    }
}

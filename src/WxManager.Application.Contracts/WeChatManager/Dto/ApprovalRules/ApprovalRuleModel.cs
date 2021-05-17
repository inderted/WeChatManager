using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;
using WxManager.Domain.Shared.ApprovalRules;

namespace WxManager.Application.Contracts.WeChatManager.ApprovalRules
{
    public class ApprovalRuleModel : EntityDto<int>
    {
        [Display(Name = "名称")]
        public string Name { get; set; }
        [Display(Name = "类型")]
        public ApprovalRuleType ApprovalRuleType { get; set; }
        [Display(Name = "状态")]
        public ApprovalRuleStatus ApprovalRuleStatus { get; set; }
        [Display(Name = "审批组")]
        public string ApprovalGroupName { get; set; }

        public DateTime CreatedOnUtc { get; set; }
        public string CreatedByCustomerName { get; set; }
        public int? UpdateByCustomerId { get; set; }
        public string UpdateByCustomerName { get; set; }

        public int ApprovalRuleTypeId { get; set; }
        public int ApprovalRuleStatusId { get; set; }
        public string ApprovalRuleTypeName { get; set; }
        public string ApprovalRuleStatusName { get; set; }
        public string RuleJson { get; set; }
        public DateTime? UpdateOnUtc { get; set; }
        public int CreatedByCustomerId { get; set; }
        public int ApprovalGroupId { get; set; }


    }
}

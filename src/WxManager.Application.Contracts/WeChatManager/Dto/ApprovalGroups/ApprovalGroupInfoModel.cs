using System;
using Volo.Abp.Application.Dtos;

namespace WxManager.Application.Contracts.WeChatManager.ApprovalGroups
{
    public class ApprovalGroupInfoModel : EntityDto<int>
    {
        public ApprovalGroupInfoModel()
        {

        }

        /// <summary>
        /// 审批组Id
        /// </summary>
        public string ApprovalGroupId { get; set; }

        /// <summary>
        /// 审批组名称
        /// </summary>
        public string ApprovalGroupName { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// 创建者Id
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedTime { get; set; }

    }
}

using System;
using Volo.Abp.Application.Dtos;

namespace WxManager.Application.Contracts.WeChatManager.ApprovalGroups
{
    public class ApprovalGroupModel : EntityDto<int>
    {
        public ApprovalGroupModel()
        {

        }

        /// <summary>
        /// 审批组名称
        /// </summary>
        public string ApprovalGroupName { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>

        public string CreatedBy { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// 更新者
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdatedTime { get; set; }


    }
}

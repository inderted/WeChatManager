using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace WxManager.Application.Contracts.WeChatManager.ApprovalGroups
{
    public class ApprovalGroupSearchModel : EntityDto<int>
    {
        public ApprovalGroupSearchModel()
        {

        }

        /// <summary>
        /// 审批组名称
        /// </summary>

        public string ApprovalGroupName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [UIHint("DateTimeNullable")]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [UIHint("DateTimeNullable")]
        public DateTime? UpdatedTime { get; set; }

    }
}

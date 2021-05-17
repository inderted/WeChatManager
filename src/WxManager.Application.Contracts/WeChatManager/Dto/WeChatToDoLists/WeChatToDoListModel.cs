using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;
using WxManager.Domain.Shared.WeChatToDoLists;

namespace WxManager.Application.Contracts.WeChatManager.WeChatToDoLists
{
    /// <summary>
    /// 任务列表
    /// </summary>
    public class WeChatToDoListModel : EntityDto<int>
    {
        /// <summary>
        /// 任务名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 截至时间
        /// </summary>
        [UIHint("DateTimeNullable")]
        public DateTime? OverTime { get; set; }

        /// <summary>
        /// 重要
        /// </summary>
        public bool Important { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 关联粉丝
        /// </summary>
        public int WeChatUserId { get; set; }
        public string WeChatUserName { get; set; }

        /// <summary>
        /// 创建者-customer
        /// </summary>
        public int CreatedByCustomerId { get; set; }
        public string CreatedByCustomerName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// 关闭者-customer
        /// </summary>
        public int? ClosedByCustomerId { get; set; }
        public string ClosedByCustomerName { get; set; }
        /// <summary>
        /// 关闭时间
        /// </summary>
        public DateTime? ClosedOn { get; set; }

        /// <summary>
        /// 完成内容说明
        /// </summary>
        public string ClosedNote { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        public int ToDoStatusId { get; set; }

        public ToDoStatus ToDoStatus
        {
            get { return (ToDoStatus)ToDoStatusId; }
            set { ToDoStatusId = (int)value; }
        }

        public int WeChatConfigId { get; set; }
    }
}

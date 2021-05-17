using System;
using Volo.Abp.Domain.Entities;
using WxManager.Domain.Shared.WeChatToDoLists;

namespace WxManager.WeChatManager.WeChatToDoLists
{
    public class WeChatToDoList : Entity<int>
    {
        /// <summary>
        /// 任务名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 截至时间
        /// </summary>
        public DateTime OverTimeUtc { get; set; }

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

        /// <summary>
        /// 创建者-customer
        /// </summary>
        public int CreatedByCustomerId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }

        public int? ClosedByCustomerId { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? ClosedOnUtc { get; set; }

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



using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;
using WxManager.Domain.Shared.WeChatToDoLists;

namespace WxManager.Application.Contracts.WeChatManager.WeChatToDoLists
{
    /// <summary>
    /// 查询任务列表
    /// </summary>
    public class WeChatToDoListSearchModel : EntityDto<int>
    {
        /// <summary>
        /// 任务名称
        /// </summary>
        public string SearchName { get; set; }

        /// <summary>
        /// 最近截至时间
        /// </summary>
        [UIHint("DateTimeNullable")]
        public DateTime? EndOverTime { get; set; }

        /// <summary>
        /// 重要
        /// </summary>
        public bool? Important { get; set; }

        /// <summary>
        /// 粉丝昵称
        /// </summary>
        public string SearchNickName { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        public ToDoStatus? ToDoStatus { get; set; }
    }
}

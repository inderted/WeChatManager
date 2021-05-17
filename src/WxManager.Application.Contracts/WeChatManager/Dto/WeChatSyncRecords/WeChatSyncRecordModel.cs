using System;
using Volo.Abp.Application.Dtos;

namespace WxManager.Application.Contracts.WeChatManager.WeChatSyncRecords
{
    public class WeChatSyncRecordModel : EntityDto<int>
    {
        /// <summary>
        /// 记录类型
        /// </summary>
        public int RecordType { get; set; }
        public string RecordTypeStr { get; set; }
        /// <summary>
        /// 同步状态
        /// </summary>
        public int SyncStatus { get; set; }
        public string SyncStatusStr { get; set; }
        /// <summary>
        /// 信息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 同步数量
        /// </summary>
        public int SyncQuantity { get; set; }
        /// <summary>
        /// 同步开始时间
        /// </summary>
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// 同步结束时间
        /// </summary>
        public DateTime? EndTime { get; set; }
    }
}

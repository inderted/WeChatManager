using System;
using Volo.Abp.Domain.Entities;
using WxManager.WeChatManager.WeChatConfigs;

namespace WxManager.WeChatManager.WeChatSyncRecords
{
    public class WeChatSyncRecord : Entity<int>
    {
        /// <summary>
        /// 关联公众号配置Id
        /// </summary>
        public int WeChatConfigId { get; set; }

        /// <summary>
        /// 记录类型
        /// </summary>
        public virtual RecordType RecordType
        {
            get => (RecordType)this.RecordTypeId;
            set => this.RecordTypeId = (int)value;
        }
        /// <summary>
        /// 记录类型Id
        /// </summary>
        public int RecordTypeId { get; set; }
        /// <summary>
        /// 同步数量
        /// </summary>
        public int SyncQuantity { get; set; }

        public string Message { get; set; }

        /// <summary>
        /// 记录状态
        /// </summary>
        public virtual SyncStatus SyncStatus
        {
            get => (SyncStatus)this.SyncStatusId;
            set => this.SyncStatusId = (int)value;
        }
        /// <summary>
        /// 同步状态Id
        /// </summary>
        public int SyncStatusId { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? StartTimeUtc { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? EndTimeUtc { get; set; }

        public virtual WeChatConfig WeChatConfig { get; set; }
    }
}

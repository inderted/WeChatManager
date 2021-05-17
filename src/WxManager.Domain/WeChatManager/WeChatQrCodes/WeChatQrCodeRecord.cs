using System;
using Volo.Abp.Domain.Entities;
using WxManager.Domain.Shared.WeChatQrCodes;

namespace WxManager.WeChatManager.WeChatQrCodes
{
    public class WeChatQrCodeRecord : Entity<int>
    {
        public int WeChatQrCodeId { get; set; }

        public string OpenId { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        /// <summary>
        /// 关联公众号配置Id
        /// </summary>
        public int WeChatConfigId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int ScanTypeId { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public ScanType ScanType
        {
            get => (ScanType)this.ScanTypeId;
            set => this.ScanTypeId = (int)value;
        }

        public virtual WeChatQrCode WeChatQrCode { get; set; }
    }
}

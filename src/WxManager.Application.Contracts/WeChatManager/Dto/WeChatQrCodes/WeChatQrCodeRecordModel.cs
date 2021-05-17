using System;
using Volo.Abp.Application.Dtos;
using WxManager.Application.Contracts.Common;
using WxManager.Domain.Shared.WeChatQrCodes;

namespace WxManager.Application.Contracts.WeChatManager.WeChatQrCodes
{
    public class WeChatQrCodeRecordModel : EntityDto<int>
    {
        /// <summary>
        /// 二维码记录名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 关联二维码
        /// </summary>
        public int WeChatQrCodeId { get; set; }

        /// <summary>
        /// 用户
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 客户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 客户Id
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 扫描时间
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }

        /// <summary>
        /// 扫描时间
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// 关联公众号配置Id
        /// </summary>
        public int WeChatConfigId { get; set; }

        /// <summary>
        /// 扫描类型
        /// </summary>
        public int ScanTypeId { get; set; }
        /// <summary>
        ///  扫描类型
        /// </summary>
        public ScanType ScanType
        {
            get => (ScanType)this.ScanTypeId;
            set => this.ScanTypeId = (int)value;
        }

        /// <summary>
        /// 扫描类型
        /// </summary>
        public string ScanTypeStr
        {
            get => WxCommonHelper.GetEnumDescription(this.ScanType);
            set
            {
            }
        }
    }
}

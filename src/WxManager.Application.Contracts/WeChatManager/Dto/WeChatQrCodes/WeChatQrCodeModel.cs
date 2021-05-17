using Senparc.Weixin.MP;
using System;
using Volo.Abp.Application.Dtos;

namespace WxManager.Application.Contracts.WeChatManager.WeChatQrCodes
{
    public class WeChatQrCodeModel : EntityDto<int>
    {
        /// <summary>
        /// 二维码有效时间
        /// </summary>
        public int? Expire { get; set; }

        /// <summary>
        /// 二维码类型
        /// </summary>
        public int ActionNameId { get; set; }

        /// <summary>
        /// 二维码类型
        /// </summary>
        public QrCode_ActionName ActionName
        {
            get => (QrCode_ActionName)this.ActionNameId;
            set => this.ActionNameId = (int)value;
        }

        /// <summary>
        /// 类别
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 场景Id
        /// </summary>
        public int SceneId { get; set; }

        /// <summary>
        /// 场景Id
        /// </summary>
        public string SceneStr { get; set; }

        /// <summary>
        /// 链接
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 密钥
        /// </summary>
        public string Ticket { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// 关联公众号配置Id
        /// </summary>
        public int WeChatConfigId { get; set; }

        /// <summary>
        /// 自动标记标签
        /// </summary>
        public bool AutoMarkTag { get; set; }

        /// <summary>
        /// 关联标签
        /// </summary>
        public int? WeChatTagId { get; set; }
    }
}

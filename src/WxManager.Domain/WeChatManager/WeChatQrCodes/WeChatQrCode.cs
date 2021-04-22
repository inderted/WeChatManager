using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WxManager.WeChatManager.WeChatConfigs;
using WxManager.WeChatManager.WeChatTags;
using Senparc.Weixin.MP;
using Volo.Abp.Domain.Entities;

namespace WxManager.WeChatManager.WeChatQrCodes
{
    public class WeChatQrCode : Entity<int>
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
        /// 类型
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

        ///// <summary>
        ///// 关键字
        ///// </summary>
        //public string KeyWord { get; set; }

        /// <summary>
        /// 注释
        /// </summary>
        public string Name { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        /// <summary>
        /// 关联标签Id
        /// </summary>
        public int? WeChatTagId { get; set; }

        public virtual WeChatTag WeChatTag { get; set; }

        /// <summary>
        /// 关联公众号配置Id
        /// </summary>
        public int WeChatConfigId { get; set; }

        public virtual WeChatConfig WeChatConfig { get; set; }
    }
}

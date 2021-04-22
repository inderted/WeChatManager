using System;
using System.Collections.Generic;
using WxManager.WeChatManager.WeChatConfigs;
using Senparc.Weixin.MP;
using Volo.Abp.Domain.Entities;

namespace WxManager.WeChatManager.WeChatMedias
{
    public class WeChatMedia : Entity<int>
    {

        public int WeChatConfigId { get; set; }

        /// <summary>
        /// 微信ID
        /// </summary>
        public string MediaId { get; set; }

        //public string  FileExtension { get; set; }

        public string FileName { get; set; } 

        /// <summary>
        /// 素材类型
        /// </summary>
        public int MediaTypeId { get; set; }

        /// <summary>
        /// 上传素来类型
        /// </summary>
        public UploadMediaFileType UploadMediaFileType
        {
            get => (UploadMediaFileType)this.MediaTypeId;
            set => this.MediaTypeId = (int)value;
        }

        /// <summary>
        /// 视频/图文 素材标题
        /// </summary>
        public string Title { get; set; }


        /// <summary>
        /// 视频 素材描述 
        /// </summary>
        public string Introduction { get; set; }

        /// <summary>
        /// 素材的具体内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 图片 素材URL
        /// </summary>
        public string Url { get; set; }

        public DateTime? UpdateTimeUtc { get; set; }

        public virtual WeChatConfig WeChatConfig { get; set; }

        /// <summary>
        /// 关联图文明细  最多8个
        /// </summary>
        public virtual ICollection<WeChatNews> WeChatNewsItems { get; set; } = new List<WeChatNews>();
    }
}

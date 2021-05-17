using Senparc.Weixin.MP;
using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace WxManager.Application.Contracts.WeChatManager.WeChatMedias
{
    public class WeChatMediaModel : EntityDto<int>
    {
        public WeChatMediaModel()
        {
            NewsModels = new List<WeChatNewsModel>();
        }
        public int WeChatConfigId { get; set; }

        /// <summary>
        /// 微信ID
        /// </summary>
        public string MediaId { get; set; }

        //public string  FileExtension { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
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
        /// 图片 素材URL
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? UpdateTimeUtc { get; set; }

        public string WebUrl { get; set; }

        public IList<WeChatNewsModel> NewsModels { get; set; }

    }
}

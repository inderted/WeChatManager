using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WxManager.WeChatManager.WeChatConfigs;
using WxManager.WeChatManager.WeChatMessages;
using Senparc.Weixin.MP;
using Volo.Abp.Domain.Entities;

namespace WxManager.WeChatManager.WeChatMedias
{
    public class WeChatTempMedia : Entity<int>
    {
        public int WeChatConfigId { get; set; }

        public string FileName { get; set; }

        public byte[] Content { get; set; }

        public int UploadMediaFileTypeId { get; set; }

        public UploadMediaFileType UploadMediaFileType
        {
            get => (UploadMediaFileType)this.UploadMediaFileTypeId;
            set => this.UploadMediaFileTypeId = (int)value;
        }

        public int? WeChatMessageId { get; set; }

        public string FromUserOpenId { get; set; }

        public string MediaId { get; set; }

        public string Url { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public virtual WeChatConfig WeChatConfig { get; set; }
    }
}

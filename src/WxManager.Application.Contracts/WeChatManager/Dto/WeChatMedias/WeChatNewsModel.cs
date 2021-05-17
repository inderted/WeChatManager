using Volo.Abp.Application.Dtos;

namespace WxManager.Application.Contracts.WeChatManager.WeChatMedias
{
    public class WeChatNewsModel : EntityDto<int>
    {
        /// <summary>
        /// 外键 微信素材Id
        /// </summary>
        public int WeChatMediaId { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 封面Id
        /// </summary>
        public string ThumbMediaId { get; set; }

        /// <summary>
        /// 封面URL
        /// </summary>
        public string ThumbMediaUrl { get; set; }

        /// <summary>
        /// 是否显示封面
        /// </summary>
        public bool ShowCoverPic { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        public string Digest { get; set; }

        /// <summary>
        /// 素材的具体内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 微信链接
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 图文 原文地址Url
        /// </summary>
        public string ConetntSourceUrl { get; set; }

        /// <summary>
        /// 是否打开评论
        /// </summary>
        public bool NeedOpenComment { get; set; }

        /// <summary>
        /// 是否粉丝才可评论
        /// </summary>
        public bool OnlyFansCanComment { get; set; }
    }
}

using System;
using Volo.Abp.Application.Dtos;

namespace WxManager.Application.Contracts.WeChatManager.WeChatAnalysis
{
    public class WeChatStatisticsArticleModel : EntityDto<int>
    {
        /// <summary>
        /// 微信数据源
        /// </summary>
        public string DataSource { get; set; }

        public int DataSourceId { get; set; }

        /// <summary>
        /// 关联公众号
        /// </summary>
        public int WeChatConfigId { get; set; }

        /// <summary>
        /// 数据日期
        /// </summary>
        public DateTime RefDate { get; set; }

        /// <summary>
        /// 数据的小时数
        /// 包括从000到2300，分别代表的是[000,100)到[2300,2400)，即每日的第1小时和最后1小时
        /// </summary>
        public int? RefHour { get; set; }

        /// <summary>
        /// 图文消息id
        /// 这也就是群发接口调用后返回的msgdataid）和index（消息次序索引）组成， 
        /// 例如120033， 其中12003是msgid，即一次群发的消息的id； 3为index，
        /// 假设该次群发的图文消息共5个文章（因为可能为多图文），3表示5个中的第3个
        /// </summary>
        public string MsgId { get; set; }

        /// <summary>
        /// 图文消息的标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 图文页（点击群发图文卡片进入的页面）的阅读人数
        /// </summary>
        public int? IntPageReadUser { get; set; }

        /// <summary>
        /// 图文页的阅读次数
        /// </summary>
        public int? IntPageReadCount { get; set; }

        /// <summary>
        /// 原文页（点击图文页“阅读原文”进入的页面）的阅读人数，无原文页时此处数据为0
        /// </summary>
        public int? OriPageReadUser { get; set; }

        /// <summary>
        /// 原文页的阅读次数
        /// </summary>
        public int? OriPageReadCount { get; set; }

        /// <summary>
        /// 分享的场景 1代表好友转发 2代表朋友圈 3代表腾讯微博 255代表其他
        /// </summary>
        public int? ShareScene { get; set; }

        /// <summary>
        /// 分享的人数
        /// </summary>
        public int? ShareUser { get; set; }

        /// <summary>
        /// 分享的次数
        /// </summary>
        public int? ShareCount { get; set; }

        /// <summary>
        /// 收藏的人数
        /// </summary>
        public int? AddToFavUser { get; set; }

        /// <summary>
        /// 收藏的次数
        /// </summary>
        public int? AddToFavCount { get; set; }

        /// <summary>
        /// 在获取图文阅读分时数据时才有该字段，代表用户从哪里进入来阅读该图文。
        /// 0:会话;1.好友;2.朋友圈;3.腾讯微博;4.历史消息页;5.其他;6.看一看;7.搜一搜
        /// </summary>
        public int? UserSource { get; set; }

    }
}

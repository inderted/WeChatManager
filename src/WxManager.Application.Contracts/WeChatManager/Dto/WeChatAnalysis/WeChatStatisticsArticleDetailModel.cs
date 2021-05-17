using System;
using Volo.Abp.Application.Dtos;

namespace WxManager.Application.Contracts.WeChatManager.WeChatAnalysis
{
    public class WeChatStatisticsArticleDetailModel : EntityDto<int>
    {
        /// <summary>
        /// 图文统计Id
        /// </summary>
        public int WeChatStatisticsArticleId { get; set; }

        /// <summary>
        /// 统计的日期
        /// 在getarticletotal接口中，refdate指的是文章群发出日期， 而statdate是数据统计日期
        /// </summary>
        public DateTime? StatDate { get; set; }

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
        /// 送达人数，一般约等于总粉丝数（需排除黑名单或其他异常情况下无法收到消息的粉丝）
        /// </summary>
        public int? TargetUser { get; set; }

        /// <summary>
        /// 公众号会话阅读人数
        /// </summary>
        public int? IntPageFromSessionReadUser { get; set; }

        /// <summary>
        /// 公众号会话阅读次数
        /// </summary>
        public int? IntPageFromSessionReadCount { get; set; }

        /// <summary>
        /// 历史消息页阅读人数
        /// </summary>
        public int? IntPageFromHistMsgReadUser { get; set; }

        /// <summary>
        /// 历史消息页阅读次数
        /// </summary>
        public int? IntPageFromHistMsgReadCount { get; set; }

        /// <summary>
        /// 朋友圈阅读人数
        /// </summary>
        public int? IntPageFromFeedReadUser { get; set; }

        /// <summary>
        /// 朋友圈阅读次数
        /// </summary>
        public int? IntPageFromFeedReadCount { get; set; }

        /// <summary>
        /// 好友转发阅读人数
        /// </summary>
        public int? IntPageFromFriendsReadUser { get; set; }

        /// <summary>
        /// 好友转发阅读次数
        /// </summary>
        public int? IntPageFromFriendsReadCount { get; set; }

        /// <summary>
        /// 其他场景阅读人数
        /// </summary>
        public int? IntPageFromOtherReadUser { get; set; }

        /// <summary>
        /// 其他场景阅读次数
        /// </summary>
        public int? IntPageFromOtherReadCount { get; set; }

        /// <summary>
        /// 公众号会话转发朋友圈人数
        /// </summary>
        public int? FeedShareFromSessionUser { get; set; }

        /// <summary>
        /// 公众号会话转发朋友圈次数
        /// </summary>
        public int? FeedShareFromSessionCnt { get; set; }

        /// <summary>
        /// 朋友圈转发朋友圈人数
        /// </summary>
        public int? FeedShareFromFeedUser { get; set; }

        /// <summary>
        /// 朋友圈转发朋友圈次数
        /// </summary>
        public int? FeedShareFromFeedCnt { get; set; }

        /// <summary>
        /// 其他场景转发朋友圈人数
        /// </summary>
        public int? FeedShareFromOtherUser { get; set; }

        /// <summary>
        /// 其他场景转发朋友圈次数
        /// </summary>
        public int? FeedShareFromOtherCnt { get; set; }

    }
}

using System;
using Volo.Abp.Application.Dtos;

namespace WxManager.Application.Contracts.WeChatManager.WeChatAnalysis
{
    public class WeChatStatisticsMsgModel : EntityDto<int>
    {
        /// <summary>
        /// 数据日期
        /// </summary>
        public DateTime RefDate { get; set; }

        /// <summary>
        /// 关联公众号
        /// </summary>
        public int WeChatConfigId { get; set; }

        /// <summary>
        /// 微信数据源
        /// </summary>
        public string DataSource { get; set; }

        /// <summary>
        /// 数据的小时
        /// </summary>
        public int? RefHour { get; set; }

        /// <summary>
        /// 消息类型，代表含义如下： 1代表文字 2代表图片 3代表语音 4代表视频 6代表第三方应用消息（链接消息）
        /// </summary>
        public int? MsgType { get; set; }

        /// <summary>
        /// 上行发送了（向公众号发送了）消息的用户数
        /// </summary>
        public int? MsgUser { get; set; }

        /// <summary>
        /// 上行发送了消息的消息总数
        /// </summary>
        public int? MsgCount { get; set; }

        /// <summary>
        /// 当日发送消息量分布的区间，0代表 “0”，1代表“1-5”，2代表“6-10”，3代表“10次以上”
        /// </summary>
        public int? CountInterval { get; set; }

        /// <summary>
        /// 图文页的阅读次数
        /// </summary>
        public int? IntPageReadCount { get; set; }

        /// <summary>
        /// 原文页（点击图文页“阅读原文”进入的页面）的阅读人数，无原文页时此处数据为0
        /// </summary>
        public int? OriPageReadUser { get; set; }
    }
}

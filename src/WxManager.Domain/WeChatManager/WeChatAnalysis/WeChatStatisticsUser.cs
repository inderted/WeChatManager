using System;
using Volo.Abp.Domain.Entities;

namespace WxManager.WeChatManager.WeChatAnalysis
{
    public class WeChatStatisticsUser : Entity<int>
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
        public int DataSourceId { get; set; }

        /// <summary>
        /// 用户的渠道，数值代表的含义如下：
        /// 0代表其他合计 
        /// 1代表公众号搜索 
        /// 17代表名片分享 
        /// 30代表扫描二维码 
        /// 43代表图文页右上角菜单 
        /// 51代表支付后关注（在支付完成页） 
        /// 57代表图文页内公众号名称 
        /// 75代表公众号文章广告 
        /// 78代表朋友圈广告
        /// </summary>
        public int? UserSource { get; set; }

        /// <summary>
        /// 新增用户数量
        /// </summary>
        public int? NewUser { get; set; }

        /// <summary>
        /// 取消关注的用户数量，newuser减去canceluser即为净增用户数量
        /// </summary>
        public int? CancelUser { get; set; }

        /// <summary>
        /// 每次更新总的用户数量
        /// </summary>
        public int? CumulateUser { get; set; }

        public AnalysisDataSourseType AnalysisDataSourseType
        {
            get => (AnalysisDataSourseType)DataSourceId;
            set => DataSourceId = (int)value;
        }
    }
}

using System;
using Volo.Abp.Application.Dtos;

namespace WxManager.Application.Contracts.WeChatManager.WeChatAnalysis
{
    public class WeChatStatisticsInterfaceModel : EntityDto<int>
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
        /// 通过服务器配置地址获得消息后，被动回复用户消息的次数
        /// </summary>
        public int? CallbackCount { get; set; }

        /// <summary>
        /// 上述动作的失败次数
        /// </summary>
        public int? FailCount { get; set; }

        /// <summary>
        /// 总耗时，除以callbackcount即为平均耗时
        /// </summary>
        public int? TotalTimeCost { get; set; }

        /// <summary>
        /// 最大耗时
        /// </summary>
        public int? MaxTimeCost { get; set; }
    }
}

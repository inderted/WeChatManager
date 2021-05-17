using System;
using Volo.Abp.Application.Dtos;

namespace WxManager.Application.Contracts.WeChatManager.WeChatAnalysis
{
    public class DataSourceListModel : EntityDto<int>
    {
        /// <summary>
        /// wx数据源
        /// </summary>
        public string DataSource { get; set; }

        /// <summary>
        /// 数据同步起始时间
        /// </summary>
        public DateTime DataAnalysisTime { get; set; }
    }
}

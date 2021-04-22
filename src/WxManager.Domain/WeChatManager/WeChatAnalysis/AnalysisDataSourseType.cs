using System;
using System.Collections.Generic;
using System.Text;

namespace WxManager.WeChatManager.WeChatAnalysis
{
    public enum AnalysisDataSourseType
    {
        GetUserSummary = 1,
        GetUserCumulate = 2,
        GetArticleSummary = 3,
        GetArticleTotal = 4,
        GetUserRead = 5,
        GetUserReadHour = 6,
        GetUserShare = 7,
        GetUserShareHour = 8,
        GetUpStreamMsg = 9,
        GetUpStreamMsgHour = 10,
        GetUpStreamMsgWeek = 11,
        GetUpStreamMsgMonth = 12,
        GetUpStreamMsgDist = 13,
        GetUpStreamMsgDistWeek = 14,
        GetUpStreamMsgDistMonth = 15,
        GetInterFaceSummary = 16,
        GetInterFaceSummaryHour = 17

    }
}

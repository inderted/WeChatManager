using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WxManager.WeChatManager.WeChatSyncRecords
{
    /// <summary>
    /// 记录类型
    /// </summary>
    public enum RecordType
    {
        WeChatUser = 1,
        WeChatTag = 2,
        WeChatUserInfo = 3,
        WeChatMedia = 4,
        WeChatMenu = 5,
        WeChatUserSummary = 6,
        WeChatUserCumulate = 7,
        WeChatArticleSummary = 8,
        WeChatArticleTotal = 9,
        WeChatUserRead = 10,
        WeChatUserReadHour = 11,
        WeChatUserShare = 12,
        WeChatUserShareHour = 13,
        WeChatUpStreamMsg = 14,
        WeChatUpStreamMsgHour = 15,
        WeChatUpStreamMsgWeek = 16,
        WeChatUpStreamMsgMonth = 17,
        WeChatUpStreamMsgDist = 18,
        WeChatUpStreamMsgDistWeek = 19,
        WeChatUpStreamMsgDistMonth = 20,
        WeChatInterFaceSummary = 21,
        WeChatInterFaceSummaryHour = 22,
    }
}

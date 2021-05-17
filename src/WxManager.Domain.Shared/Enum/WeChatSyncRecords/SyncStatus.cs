using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WxManager.Domain.Shared.WeChatSyncRecords
{
    /// <summary>
    /// 同步状态
    /// </summary>
    public enum SyncStatus
    {
        Syncing = 1,
        Ok = 2,
        Error = 3
    }
}

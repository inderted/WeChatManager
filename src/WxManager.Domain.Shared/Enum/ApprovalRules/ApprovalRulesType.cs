using System;
using System.Collections.Generic;
using System.Text;

namespace WxManager.Domain.Shared.ApprovalRules
{
    public enum ApprovalRuleType
    {
        串行 = 0,
        并行 = 1
    }
    public enum ApprovalRuleStatus
    {
        草稿 = 0,
        启用 = 1,
        停用 = 2
    }
}

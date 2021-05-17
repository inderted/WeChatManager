using System.ComponentModel;

namespace WxManager.Domain.Shared.WeChatQrCodes
{
    public enum ScanType
    {
        [Description("关注")]
        Subscribe,
        [Description("扫描")]
        Scan
    }
}

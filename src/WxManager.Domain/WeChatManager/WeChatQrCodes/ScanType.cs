using System.ComponentModel;

namespace WxManager.WeChatManager.WeChatQrCodes
{
    public enum ScanType
    {
        [Description("关注")]
        Subscribe,
        [Description("扫描")]
        Scan
    }
}

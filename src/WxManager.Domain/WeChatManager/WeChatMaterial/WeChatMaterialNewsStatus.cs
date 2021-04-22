namespace WxManager.WeChatManager.WeChatMaterial
{
    /// <summary>
    /// 图文状态
    /// </summary>
    public enum WeChatMaterialNewsStatus
    {
        /// <summary>
        /// 草稿
        /// </summary>
        Draft = 10,
        /// <summary>
        /// 审核中
        /// </summary>
        Auditing = 20,
        /// <summary>
        /// 审核通过
        /// </summary>
        Approved = 30,
        /// <summary>
        /// 审核失败
        /// </summary>
        AuditFailure = 40
    }
}

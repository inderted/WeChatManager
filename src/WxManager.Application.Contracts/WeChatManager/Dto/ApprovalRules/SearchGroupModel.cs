using Volo.Abp.Application.Dtos;

namespace WxManager.Application.Contracts.WeChatManager.ApprovalRules
{
    public class SearchApprovalModel : EntityDto<int>
    {
        public string Name { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using WxManager.Application.Contracts.WeChatManager.WeChatConfigs;
using WxManager.Domain.Shared.PagedList;

namespace WxManager.WeChatManager.IService
{
    public interface IWeChatConfigService : IApplicationService
    {
        Task<IEnumerable<WeChatConfigModel>> PageWeChatConfigModel();

        Task<WeChatConfigModel> GetWeChatConfigById(int id);
    }
}

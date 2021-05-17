using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;
using WxManager.Domain.IRepository;
using WxManager.Domain.Shared.PagedList;
using WxManager.WeChatManager.WeChatConfigs;

namespace WxManager.Domain.WeChatConfigs
{
    public interface IWeChatConfigRepository : IEfRepository<WeChatConfig, int>
    {

    }
}
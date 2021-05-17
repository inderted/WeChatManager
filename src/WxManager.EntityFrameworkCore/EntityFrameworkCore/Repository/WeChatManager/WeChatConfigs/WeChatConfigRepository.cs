using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Senparc.Weixin.MP.Containers;
using Volo.Abp.EntityFrameworkCore;
using WxManager.Domain.Shared.PagedList;
using WxManager.Domain.WeChatConfigs;
using WxManager.WeChatManager.WeChatConfigs;

namespace WxManager.EntityFrameworkCore.Repository.WeChatConfigs
{
    public class WeChatConfigRepository : EfRepository<WxManagerDbContext, WeChatConfig, int>, IWeChatConfigRepository
    {
        #region 字段

        public WeChatConfigRepository(IDbContextProvider<WxManagerDbContext> dbContextProvider)
        : base(dbContextProvider)
        {

        }

        #endregion

        public async Task Insert(WeChatConfig weChatConfig)
        {
            if (weChatConfig == null)
                throw new ArgumentNullException(nameof(weChatConfig));

            await InsertAsync(weChatConfig);
            await Register(weChatConfig);
            //_eventPublisher.EntityInserted(weChatConfig);
        }

        public async Task Update(WeChatConfig weChatConfig)
        {
            if (weChatConfig == null)
                throw new ArgumentNullException(nameof(weChatConfig));
            await UpdateAsync(weChatConfig);
            await Register(weChatConfig);
            //_eventPublisher.EntityUpdated(weChatConfig);
        }

        public async Task Delete(WeChatConfig weChatConfig)
        {
            if (weChatConfig == null)
                throw new ArgumentNullException(nameof(weChatConfig));
            await DeleteAsync(weChatConfig);
            await Register(weChatConfig);
            //_eventPublisher.EntityDeleted(weChatConfig);
        }

        public async Task<WeChatConfig> GetById(int id)
        {
            if (id == 0)
                throw new ArgumentException("id不能小于0", nameof(id));
            return await GetByIdAsync(id);
        }

        public async Task<WeChatConfig> GetByAppId(string appid)
        {
            var query = await GetQueryableAsync();
            query = query.AsNoTracking();
            query = query.Where(x => x.WeChatAppId == appid && x.Deleted == false);
            return query.FirstOrDefault();
        }
        public async Task<IPagedList<WeChatConfig>> Search(bool deleted = false, int pageIndex = 0, int pageSize = int.MaxValue)
        {
            var query = await GetQueryableAsync();
            query = query.AsNoTracking();
            query = query.Where(x => x.Deleted == deleted);
            query = query.OrderBy(x => x.Id);
            return new PagedList<WeChatConfig>(query, pageIndex, pageSize);
        }

        private async Task Register(WeChatConfig weChatConfig)
        {
            await AccessTokenContainer.RegisterAsync(
                 weChatConfig.WeChatAppId,
                 weChatConfig.WeChatAppSecret,
                 weChatConfig.WeChatName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;
using WxManager.Domain.Shared.PagedList;

namespace WxManager.Domain.IRepository
{
    public interface IEfRepository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class, IEntity<TKey>
    {
        Task Delete(TEntity weChatConfig);
        Task<TEntity> GetById(int id);
        Task Insert(TEntity weChatConfig);
        Task<IPagedList<TEntity>> Search(bool deleted = false, int pageIndex = 0, int pageSize = int.MaxValue);
        Task Update(TEntity weChatConfig);
        Task<TEntity> GetByAppId(string appid);
    }
}

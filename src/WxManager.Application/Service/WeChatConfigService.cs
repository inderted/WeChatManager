using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using WxManager.Application.Caching;
using WxManager.Application.Contracts.WeChatManager.WeChatConfigs;
using WxManager.Domain.Shared.PagedList;
using WxManager.Domain.WeChatConfigs;
using WxManager.WeChatManager.IService;
using WxManager.WeChatManager.WeChatConfigs;
using WxManager.Application.Extensions;

namespace WxManager.Service
{
    public class WeChatConfigService : ApplicationService, IWeChatConfigService
    {
        private readonly IStaticCacheManager _cacheManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IWeChatConfigRepository _weChatConfigRepository;

        public WeChatConfigService(IStaticCacheManager cacheManager,
            IHttpContextAccessor httpContextAccessor,
            IWeChatConfigRepository weChatConfigRepository)
        {
            _cacheManager = cacheManager;
            _httpContextAccessor = httpContextAccessor;
            _weChatConfigRepository = weChatConfigRepository;
        }

        /// <summary>
        /// list
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<WeChatConfigModel>> PageWeChatConfigModel()
        {
            var weChatConfigList = await _weChatConfigRepository.Search();
            if (weChatConfigList == null)
                throw new ArgumentNullException(nameof(weChatConfigList));
            return weChatConfigList.Select((x) =>
            {
                var key = string.Format(ModelCacheEventConsumer.WeChatConfigId_Key, x.Id);
                var weChatConfigModel = _cacheManager.Get(key, () =>
                {
                    var model = x.ToModel(ObjectMapper);
                    return model;
                }, ModelCacheEventConsumer.WeChatSetting_KEY_CacheTime);
                if (weChatConfigModel == null)
                    return null;
                weChatConfigModel.WeChatVerifyUrl = $"{_httpContextAccessor.HttpContext.Request.PathBase.Value}WxNotify/{x.Id}";
                return weChatConfigModel;
            });
        }

        /// <summary>
        /// GetById
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<WeChatConfigModel> GetWeChatConfigById(int id)
        {
            if (id == 0)
                throw new ArgumentNullException(nameof(id));
            var key = string.Format(ModelCacheEventConsumer.WeChatConfigId_Key, id);
            var weChatConfigModel = await _cacheManager.Get(key, async () =>
            {
                var weChatConfig = await _weChatConfigRepository.GetById(id);
                var model = weChatConfig.ToModel(ObjectMapper);
                return model;
            }, ModelCacheEventConsumer.WeChatSetting_KEY_CacheTime);
            if (weChatConfigModel == null)
                return null;
            string url = null;

            url = $"Notice/{id}";

            weChatConfigModel.WeChatVerifyUrl = $"{_httpContextAccessor.HttpContext.Request.PathBase.Value}{url}";
            return weChatConfigModel;

        }
    }
}

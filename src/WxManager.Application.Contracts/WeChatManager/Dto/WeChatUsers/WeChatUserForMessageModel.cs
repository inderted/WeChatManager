using System.Collections.Generic;
using WxManager.Application.Contracts.WeChatManager.WeChatMessages;
using Volo.Abp.Application.Dtos;

namespace WxManager.Application.Contracts.WeChatManager.WeChatUsers
{
    public class WeChatUserForMessageModel : EntityDto<int>
    {
        public WeChatUserForMessageModel()
        {
            Messages = new List<WeChatMessageModel>();
        }
        /// <summary>
        /// 微信OpenId
        /// </summary>
        public string OpenId { get; set; }
        /// <summary>
        /// 关联Nop客户
        /// </summary>
        public int CustomerId { get; set; }
        /// <summary>
        /// 是否订阅
        /// </summary>
        public bool Subscribe { get; set; }

        /// <summary>
        /// 用户的昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 用户头像，最后一个数值代表正方形头像大小（有0、46、64、96、132数值可选，0代表640*640正方形头像），用户没有头像时该项为空。若用户更换头像，原有头像URL将失效。
        /// </summary>
        public string HeadImgUrl { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 未读数
        /// </summary>
        public int NotReadNum { get; set; }

        /// <summary>
        /// 之前是否还有信息
        /// </summary>
        public bool HasBeforeMessage { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public string Tags { get; set; }

        /// <summary>
        /// 任务数
        /// </summary>
        public int ToDoCount { get; set; }

        /// <summary>
        /// 关联信息 一次最多加载10条
        /// </summary>
        public IList<WeChatMessageModel> Messages { get; set; }
    }
}

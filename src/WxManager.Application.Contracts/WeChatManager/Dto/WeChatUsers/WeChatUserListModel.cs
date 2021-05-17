using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace WxManager.Application.Contracts.WeChatManager.WeChatUsers
{
    public class WeChatUserListModel : EntityDto<int>
    {
        public WeChatUserListModel()
        {
            SelectedTagIds = new List<int>();
            AvailableTagIds = new List<SelectListItem>();
            Subscribe = true;
        }

        /// <summary>
        /// 昵称
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// 订阅-开始
        /// </summary>
        [UIHint("DateTimeNullable")]
        public DateTime? SubscribeTimeStart { get; set; }

        /// <summary>
        /// 订阅-结束
        /// </summary>
        [UIHint("DateTimeNullable")]
        public DateTime? SubscribeTimeEnd { get; set; }

        /// <summary>
        /// 用户所在城市
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// 用户所在国家
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// 用户所在省份
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// 是否订阅
        /// </summary>
        public bool Subscribe { get; set; }

        /// <summary>
        /// 选择标签
        /// </summary>
        [UIHint("MultiSelect")]
        public IList<int> SelectedTagIds { get; set; }

        /// <summary>
        /// 可用标签
        /// </summary>
        public IList<SelectListItem> AvailableTagIds { get; set; }

        /// <summary>
        /// 标签 与/或 0/1
        /// </summary>
        public bool TagXor { get; set; }

        /// <summary>
        /// 黑名单用户
        /// </summary>
        public bool BlackUser { get; set; }
    }
}

using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace WxManager.Application.Contracts.WeChatManager.ApprovalGroups
{
    public class CustomerModel : EntityDto<int>
    {
        public CustomerModel()
        {
            SelectedCustomerRoleIds = new List<int>();
            //AvailableCustomerRoles = new List<SelectListItem>();
            SelectCustomerIds = new List<int>();
        }

        /// <summary>
        /// 用户名称
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// 用户角色
        /// </summary>
        public string CustomerRoleNames { get; set; }

        /// <summary>
        /// Search By FirstName
        /// </summary>
        public string SearchCustomerFirstName { get; set; }

        /// <summary>
        /// Search By LastName
        /// </summary>
        public string SearchCustomerLastName { get; set; }

        public IList<int> SelectedCustomerRoleIds { get; set; }

        //public IList<SelectListItem> AvailableCustomerRoles { get; set; }

        public IList<int> SelectCustomerIds { get; set; }
    }
}

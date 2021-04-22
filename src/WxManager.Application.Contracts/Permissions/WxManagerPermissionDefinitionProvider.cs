using WxManager.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace WxManager.Permissions
{
    public class WxManagerPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(WxManagerPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(WxManagerPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<WxManagerResource>(name);
        }
    }
}

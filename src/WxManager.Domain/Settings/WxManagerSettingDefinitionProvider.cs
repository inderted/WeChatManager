using Volo.Abp.Settings;

namespace WxManager.Settings
{
    public class WxManagerSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(WxManagerSettings.MySetting1));
        }
    }
}

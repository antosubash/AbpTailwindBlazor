using Volo.Abp.Settings;

namespace AbpTailwindBlazor.Settings
{
    public class AbpTailwindBlazorSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpTailwindBlazorSettings.MySetting1));
        }
    }
}

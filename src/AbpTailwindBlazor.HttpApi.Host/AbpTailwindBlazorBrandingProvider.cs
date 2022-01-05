using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpTailwindBlazor
{
    [Dependency(ReplaceServices = true)]
    public class AbpTailwindBlazorBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpTailwindBlazor";
    }
}

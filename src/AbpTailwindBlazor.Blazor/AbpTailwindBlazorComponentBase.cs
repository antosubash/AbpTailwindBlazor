using AbpTailwindBlazor.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AbpTailwindBlazor.Blazor
{
    public abstract class AbpTailwindBlazorComponentBase : AbpComponentBase
    {
        protected AbpTailwindBlazorComponentBase()
        {
            LocalizationResource = typeof(AbpTailwindBlazorResource);
        }
    }
}

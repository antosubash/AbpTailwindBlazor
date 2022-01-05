using AbpTailwindBlazor.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpTailwindBlazor.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpTailwindBlazorController : AbpControllerBase
    {
        protected AbpTailwindBlazorController()
        {
            LocalizationResource = typeof(AbpTailwindBlazorResource);
        }
    }
}
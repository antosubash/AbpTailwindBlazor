using System;
using System.Collections.Generic;
using System.Text;
using AbpTailwindBlazor.Localization;
using Volo.Abp.Application.Services;

namespace AbpTailwindBlazor
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpTailwindBlazorAppService : ApplicationService
    {
        protected AbpTailwindBlazorAppService()
        {
            LocalizationResource = typeof(AbpTailwindBlazorResource);
        }
    }
}

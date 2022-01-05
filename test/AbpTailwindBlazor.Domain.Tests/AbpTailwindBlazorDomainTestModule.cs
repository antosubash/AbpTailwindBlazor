using AbpTailwindBlazor.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpTailwindBlazor
{
    [DependsOn(
        typeof(AbpTailwindBlazorEntityFrameworkCoreTestModule)
        )]
    public class AbpTailwindBlazorDomainTestModule : AbpModule
    {

    }
}
using Volo.Abp.Modularity;

namespace AbpTailwindBlazor
{
    [DependsOn(
        typeof(AbpTailwindBlazorApplicationModule),
        typeof(AbpTailwindBlazorDomainTestModule)
        )]
    public class AbpTailwindBlazorApplicationTestModule : AbpModule
    {

    }
}
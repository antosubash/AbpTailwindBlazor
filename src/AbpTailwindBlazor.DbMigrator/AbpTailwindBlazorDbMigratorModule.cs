using AbpTailwindBlazor.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpTailwindBlazor.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpTailwindBlazorEntityFrameworkCoreModule),
        typeof(AbpTailwindBlazorApplicationContractsModule)
        )]
    public class AbpTailwindBlazorDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}

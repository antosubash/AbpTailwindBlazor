using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpTailwindBlazor.Data
{
    /* This is used if database provider does't define
     * IAbpTailwindBlazorDbSchemaMigrator implementation.
     */
    public class NullAbpTailwindBlazorDbSchemaMigrator : IAbpTailwindBlazorDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}
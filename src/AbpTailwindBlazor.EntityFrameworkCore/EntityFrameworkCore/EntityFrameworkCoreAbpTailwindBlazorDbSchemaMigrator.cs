using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpTailwindBlazor.Data;
using Volo.Abp.DependencyInjection;

namespace AbpTailwindBlazor.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpTailwindBlazorDbSchemaMigrator
        : IAbpTailwindBlazorDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpTailwindBlazorDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpTailwindBlazorDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpTailwindBlazorDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}

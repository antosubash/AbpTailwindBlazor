using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AbpTailwindBlazor.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class AbpTailwindBlazorDbContextFactory : IDesignTimeDbContextFactory<AbpTailwindBlazorDbContext>
    {
        public AbpTailwindBlazorDbContext CreateDbContext(string[] args)
        {
            AbpTailwindBlazorEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<AbpTailwindBlazorDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new AbpTailwindBlazorDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AbpTailwindBlazor.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}

using System.Threading.Tasks;

namespace AbpTailwindBlazor.Data
{
    public interface IAbpTailwindBlazorDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}

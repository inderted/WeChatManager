using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace WxManager.Data
{
    /* This is used if database provider does't define
     * IWxManagerDbSchemaMigrator implementation.
     */
    public class NullWxManagerDbSchemaMigrator : IWxManagerDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}
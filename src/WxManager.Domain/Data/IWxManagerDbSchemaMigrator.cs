using System.Threading.Tasks;

namespace WxManager.Data
{
    public interface IWxManagerDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}

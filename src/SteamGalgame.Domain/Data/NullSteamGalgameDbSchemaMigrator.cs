using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SteamGalgame.Data;

/* This is used if database provider does't define
 * ISteamGalgameDbSchemaMigrator implementation.
 */
public class NullSteamGalgameDbSchemaMigrator : ISteamGalgameDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

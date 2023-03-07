using System.Threading.Tasks;

namespace SteamGalgame.Data;

public interface ISteamGalgameDbSchemaMigrator
{
    Task MigrateAsync();
}

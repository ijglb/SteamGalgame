using SteamGalgame.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace SteamGalgame.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SteamGalgameEntityFrameworkCoreModule),
    typeof(SteamGalgameApplicationContractsModule)
    )]
public class SteamGalgameDbMigratorModule : AbpModule
{

}

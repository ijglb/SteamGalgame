using SteamGalgame.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SteamGalgame;

[DependsOn(
    typeof(SteamGalgameEntityFrameworkCoreTestModule)
    )]
public class SteamGalgameDomainTestModule : AbpModule
{

}

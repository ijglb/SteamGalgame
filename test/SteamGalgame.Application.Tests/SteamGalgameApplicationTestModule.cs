using Volo.Abp.Modularity;

namespace SteamGalgame;

[DependsOn(
    typeof(SteamGalgameApplicationModule),
    typeof(SteamGalgameDomainTestModule)
    )]
public class SteamGalgameApplicationTestModule : AbpModule
{

}

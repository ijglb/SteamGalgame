using SteamGalgame.Localization;
using Volo.Abp.AspNetCore.Components;

namespace SteamGalgame.Blazor;

public abstract class SteamGalgameComponentBase : AbpComponentBase
{
    protected SteamGalgameComponentBase()
    {
        LocalizationResource = typeof(SteamGalgameResource);
    }
}

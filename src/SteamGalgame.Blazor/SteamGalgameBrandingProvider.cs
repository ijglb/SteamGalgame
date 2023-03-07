using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace SteamGalgame.Blazor;

[Dependency(ReplaceServices = true)]
public class SteamGalgameBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SteamGalgame";
}

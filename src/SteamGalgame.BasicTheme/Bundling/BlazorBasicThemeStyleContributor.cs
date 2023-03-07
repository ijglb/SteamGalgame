using System.Collections.Generic;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace SteamGalgame.BasicTheme.Bundling;

public class BlazorBasicThemeStyleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.AddIfNotContains("/_content/SteamGalgame.BasicTheme/libs/abp/css/theme.css");
    }
}

using Volo.Abp.Settings;

namespace SteamGalgame.Settings;

public class SteamGalgameSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SteamGalgameSettings.MySetting1));
    }
}

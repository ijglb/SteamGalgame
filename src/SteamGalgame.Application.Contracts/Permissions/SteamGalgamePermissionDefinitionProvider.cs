using SteamGalgame.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SteamGalgame.Permissions;

public class SteamGalgamePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SteamGalgamePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SteamGalgamePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SteamGalgameResource>(name);
    }
}

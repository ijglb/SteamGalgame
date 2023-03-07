using SteamGalgame.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SteamGalgame.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SteamGalgameController : AbpControllerBase
{
    protected SteamGalgameController()
    {
        LocalizationResource = typeof(SteamGalgameResource);
    }
}

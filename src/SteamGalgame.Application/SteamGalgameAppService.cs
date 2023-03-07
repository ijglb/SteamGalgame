using System;
using System.Collections.Generic;
using System.Text;
using SteamGalgame.Localization;
using Volo.Abp.Application.Services;

namespace SteamGalgame;

/* Inherit your application services from this class.
 */
public abstract class SteamGalgameAppService : ApplicationService
{
    protected SteamGalgameAppService()
    {
        LocalizationResource = typeof(SteamGalgameResource);
    }
}

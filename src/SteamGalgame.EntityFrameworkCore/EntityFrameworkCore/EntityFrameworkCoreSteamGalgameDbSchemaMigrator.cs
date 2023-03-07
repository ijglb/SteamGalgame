using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SteamGalgame.Data;
using Volo.Abp.DependencyInjection;

namespace SteamGalgame.EntityFrameworkCore;

public class EntityFrameworkCoreSteamGalgameDbSchemaMigrator
    : ISteamGalgameDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSteamGalgameDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the SteamGalgameDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SteamGalgameDbContext>()
            .Database
            .MigrateAsync();
    }
}

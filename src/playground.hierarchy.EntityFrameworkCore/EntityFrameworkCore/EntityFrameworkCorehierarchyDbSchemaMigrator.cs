using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using playground.hierarchy.Data;
using Volo.Abp.DependencyInjection;

namespace playground.hierarchy.EntityFrameworkCore;

public class EntityFrameworkCorehierarchyDbSchemaMigrator
    : IhierarchyDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCorehierarchyDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the hierarchyDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<hierarchyDbContext>()
            .Database
            .MigrateAsync();
    }
}

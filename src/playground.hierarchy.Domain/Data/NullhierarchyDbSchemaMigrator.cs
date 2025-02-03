using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace playground.hierarchy.Data;

/* This is used if database provider does't define
 * IhierarchyDbSchemaMigrator implementation.
 */
public class NullhierarchyDbSchemaMigrator : IhierarchyDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

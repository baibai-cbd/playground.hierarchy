using System.Threading.Tasks;

namespace playground.hierarchy.Data;

public interface IhierarchyDbSchemaMigrator
{
    Task MigrateAsync();
}

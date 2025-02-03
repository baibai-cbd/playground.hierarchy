using playground.hierarchy.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace playground.hierarchy.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(hierarchyEntityFrameworkCoreModule),
    typeof(hierarchyApplicationContractsModule)
)]
public class hierarchyDbMigratorModule : AbpModule
{
}

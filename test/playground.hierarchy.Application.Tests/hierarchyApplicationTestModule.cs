using Volo.Abp.Modularity;

namespace playground.hierarchy;

[DependsOn(
    typeof(hierarchyApplicationModule),
    typeof(hierarchyDomainTestModule)
)]
public class hierarchyApplicationTestModule : AbpModule
{

}

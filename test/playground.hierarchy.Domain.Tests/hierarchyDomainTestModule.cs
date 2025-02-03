using Volo.Abp.Modularity;

namespace playground.hierarchy;

[DependsOn(
    typeof(hierarchyDomainModule),
    typeof(hierarchyTestBaseModule)
)]
public class hierarchyDomainTestModule : AbpModule
{

}

using Volo.Abp.Modularity;

namespace playground.hierarchy;

public abstract class hierarchyApplicationTestBase<TStartupModule> : hierarchyTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

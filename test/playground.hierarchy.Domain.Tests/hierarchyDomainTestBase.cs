using Volo.Abp.Modularity;

namespace playground.hierarchy;

/* Inherit from this class for your domain layer tests. */
public abstract class hierarchyDomainTestBase<TStartupModule> : hierarchyTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

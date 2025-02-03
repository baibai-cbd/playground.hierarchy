using Xunit;

namespace playground.hierarchy.EntityFrameworkCore;

[CollectionDefinition(hierarchyTestConsts.CollectionDefinitionName)]
public class hierarchyEntityFrameworkCoreCollection : ICollectionFixture<hierarchyEntityFrameworkCoreFixture>
{

}

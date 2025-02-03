using playground.hierarchy.Samples;
using Xunit;

namespace playground.hierarchy.EntityFrameworkCore.Domains;

[Collection(hierarchyTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<hierarchyEntityFrameworkCoreTestModule>
{

}

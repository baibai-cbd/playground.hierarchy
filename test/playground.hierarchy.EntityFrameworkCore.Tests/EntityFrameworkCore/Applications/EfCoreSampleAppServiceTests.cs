using playground.hierarchy.Samples;
using Xunit;

namespace playground.hierarchy.EntityFrameworkCore.Applications;

[Collection(hierarchyTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<hierarchyEntityFrameworkCoreTestModule>
{

}

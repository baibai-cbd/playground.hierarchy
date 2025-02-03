using playground.hierarchy.Localization;
using Volo.Abp.Application.Services;

namespace playground.hierarchy;

/* Inherit your application services from this class.
 */
public abstract class hierarchyAppService : ApplicationService
{
    protected hierarchyAppService()
    {
        LocalizationResource = typeof(hierarchyResource);
    }
}

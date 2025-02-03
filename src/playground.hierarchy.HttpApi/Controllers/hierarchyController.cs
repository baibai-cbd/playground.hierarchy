using playground.hierarchy.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace playground.hierarchy.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class hierarchyController : AbpControllerBase
{
    protected hierarchyController()
    {
        LocalizationResource = typeof(hierarchyResource);
    }
}

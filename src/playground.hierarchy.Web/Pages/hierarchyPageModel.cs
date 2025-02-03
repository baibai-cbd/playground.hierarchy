using playground.hierarchy.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace playground.hierarchy.Web.Pages;

public abstract class hierarchyPageModel : AbpPageModel
{
    protected hierarchyPageModel()
    {
        LocalizationResourceType = typeof(hierarchyResource);
    }
}

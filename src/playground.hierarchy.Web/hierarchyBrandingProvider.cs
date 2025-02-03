using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using playground.hierarchy.Localization;

namespace playground.hierarchy.Web;

[Dependency(ReplaceServices = true)]
public class hierarchyBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<hierarchyResource> _localizer;

    public hierarchyBrandingProvider(IStringLocalizer<hierarchyResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}

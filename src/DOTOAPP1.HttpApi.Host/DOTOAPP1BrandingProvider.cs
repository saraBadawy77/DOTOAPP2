using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace DOTOAPP1;

[Dependency(ReplaceServices = true)]
public class DOTOAPP1BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "DOTOAPP1";
}

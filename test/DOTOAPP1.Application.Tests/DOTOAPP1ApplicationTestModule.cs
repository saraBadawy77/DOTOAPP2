using Volo.Abp.Modularity;

namespace DOTOAPP1;

[DependsOn(
    typeof(DOTOAPP1ApplicationModule),
    typeof(DOTOAPP1DomainTestModule)
)]
public class DOTOAPP1ApplicationTestModule : AbpModule
{

}

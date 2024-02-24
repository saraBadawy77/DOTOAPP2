using Volo.Abp.Modularity;

namespace DOTOAPP1;

[DependsOn(
    typeof(DOTOAPP1DomainModule),
    typeof(DOTOAPP1TestBaseModule)
)]
public class DOTOAPP1DomainTestModule : AbpModule
{

}

using Volo.Abp.Modularity;

namespace DOTOAPP1;

public abstract class DOTOAPP1ApplicationTestBase<TStartupModule> : DOTOAPP1TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

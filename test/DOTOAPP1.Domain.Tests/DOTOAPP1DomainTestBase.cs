using Volo.Abp.Modularity;

namespace DOTOAPP1;

/* Inherit from this class for your domain layer tests. */
public abstract class DOTOAPP1DomainTestBase<TStartupModule> : DOTOAPP1TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

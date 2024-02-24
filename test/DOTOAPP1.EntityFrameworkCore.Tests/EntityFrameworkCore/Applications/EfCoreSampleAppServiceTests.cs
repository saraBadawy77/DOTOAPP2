using DOTOAPP1.Samples;
using Xunit;

namespace DOTOAPP1.EntityFrameworkCore.Applications;

[Collection(DOTOAPP1TestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<DOTOAPP1EntityFrameworkCoreTestModule>
{

}

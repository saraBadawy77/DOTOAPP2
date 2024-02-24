using DOTOAPP1.Samples;
using Xunit;

namespace DOTOAPP1.EntityFrameworkCore.Domains;

[Collection(DOTOAPP1TestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<DOTOAPP1EntityFrameworkCoreTestModule>
{

}

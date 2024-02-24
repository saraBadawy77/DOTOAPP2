using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace DOTOAPP1.Data;

/* This is used if database provider does't define
 * IDOTOAPP1DbSchemaMigrator implementation.
 */
public class NullDOTOAPP1DbSchemaMigrator : IDOTOAPP1DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

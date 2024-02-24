using System.Threading.Tasks;

namespace DOTOAPP1.Data;

public interface IDOTOAPP1DbSchemaMigrator
{
    Task MigrateAsync();
}

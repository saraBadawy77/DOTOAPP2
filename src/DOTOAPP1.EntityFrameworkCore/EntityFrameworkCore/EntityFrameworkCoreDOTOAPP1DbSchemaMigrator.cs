using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DOTOAPP1.Data;
using Volo.Abp.DependencyInjection;

namespace DOTOAPP1.EntityFrameworkCore;

public class EntityFrameworkCoreDOTOAPP1DbSchemaMigrator
    : IDOTOAPP1DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreDOTOAPP1DbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the DOTOAPP1DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<DOTOAPP1DbContext>()
            .Database
            .MigrateAsync();
    }
}

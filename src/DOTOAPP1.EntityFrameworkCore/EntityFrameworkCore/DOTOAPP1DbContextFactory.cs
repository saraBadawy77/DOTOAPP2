using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DOTOAPP1.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class DOTOAPP1DbContextFactory : IDesignTimeDbContextFactory<DOTOAPP1DbContext>
{
    public DOTOAPP1DbContext CreateDbContext(string[] args)
    {
        DOTOAPP1EfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<DOTOAPP1DbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new DOTOAPP1DbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../DOTOAPP1.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}

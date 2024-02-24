
using DOTOAPP1.EntityFrameworkCore;
using System;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace DOTOAPP1.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DOTOAPP1EntityFrameworkCoreModule),
    typeof(DOTOAPP1ApplicationContractsModule)
    )]
public class DOTOAPP1DbMigratorModule : AbpModule
{
    

}

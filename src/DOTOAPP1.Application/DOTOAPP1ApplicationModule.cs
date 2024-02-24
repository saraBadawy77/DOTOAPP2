using DOTOAPP1.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.Data;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;


namespace DOTOAPP1;

[DependsOn(
    typeof(DOTOAPP1DomainModule),
    typeof(AbpAccountApplicationModule),
    typeof(DOTOAPP1ApplicationContractsModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule),
    typeof(DOTOAPP1EntityFrameworkCoreModule),
    typeof(DOTOAPP1DomainSharedModule)


    )]
public class DOTOAPP1ApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        

    }
}

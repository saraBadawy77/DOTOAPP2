using DOTOAPP1.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace DOTOAPP1.Permissions;

public class DOTOAPP1PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(DOTOAPP1Permissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(DOTOAPP1Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DOTOAPP1Resource>(name);
    }
}

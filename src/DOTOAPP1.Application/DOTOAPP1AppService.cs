using System;
using System.Collections.Generic;
using System.Text;
using DOTOAPP1.Localization;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Application.Services;
using Volo.Abp.Data;

namespace DOTOAPP1;

/* Inherit your application services from this class.
 */
public abstract class DOTOAPP1AppService : ApplicationService
{
    protected DOTOAPP1AppService()
    {
        LocalizationResource = typeof(DOTOAPP1Resource);
    }


}

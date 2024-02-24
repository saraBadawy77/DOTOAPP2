using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace DOTOAPP1
{
    public class TestTableDto:EntityDto<Guid>
    {
        public string name { get; set; }
        public string name2 { get; set; }

       public List<string> LogosPaths { get; set; }
    }
}

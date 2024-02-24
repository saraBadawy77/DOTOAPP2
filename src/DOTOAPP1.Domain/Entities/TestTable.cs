
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace DOTOAPP1.Entities
{
    public class TestTable: Entity<Guid>
    {
        public string name { get; set; }
        public string name2 { get; set; }

        public List<string> LogosPaths { get; set; }

    }
}

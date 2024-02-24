using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTOAPP1.Entities
{
    public class Book
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

       

        public float? Price { get; set; }
    }
}

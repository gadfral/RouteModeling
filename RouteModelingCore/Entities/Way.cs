using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteModelingCore.Entities
{
    public sealed class Way
    {
        public Location From { get; set; }

        public Location To { get; set; }
    }
}

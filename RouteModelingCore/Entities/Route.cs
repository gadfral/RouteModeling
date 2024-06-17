using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteModelingCore.Entities
{
    public sealed class Route
    {
        public string СurrencyCode { get; set; }

        public decimal FullPrice { get; set; }

        public double Time { get; set; }

        public string AutoName { get; set; }
    }
}

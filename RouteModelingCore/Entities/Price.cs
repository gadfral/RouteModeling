using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteModelingCore.Entities
{
    public sealed class Price
    {
        public decimal Tax { get; set; }

        public string СurrencyCode { get; set; }

        public decimal FullPrice { get; set; }
    }
}

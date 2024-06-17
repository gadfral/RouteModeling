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

        /// <summary>
        /// Время минутах
        /// </summary>
        public double Time { get; set; }
    }
}

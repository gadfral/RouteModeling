using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouteModelingCore.Consts;
using RouteModelingCore.Entities;

namespace RouteModelingCore.Helpers
{
    public static class AutoHelper
    {
        public static string GetName(this AutoType autoType)
        {
            return autoType switch
            {
                AutoType.None => string.Empty,
                AutoType.Moto => AutoNames.Moto,
                AutoType.Car => AutoNames.Car,
                AutoType.Truck => AutoNames.Truck,
                _ => throw new ArgumentOutOfRangeException(nameof(autoType), autoType, null)
            };
        }

    }
}

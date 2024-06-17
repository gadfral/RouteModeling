using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouteModelingCore.Entities;

namespace RouteModelingCore.Helpers
{
    public static class DimensionHelper
    {
        public static bool IsEqual(Dimensions first, Dimensions second)
        {
            if (first.Equals(second))
                return true;

            return false;
        }
    }
}

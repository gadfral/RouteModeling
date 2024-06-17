using RouteModelingCore.Context.EntityContext;
using RouteModelingCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteModelingCore.Helpers
{
    public static class WeightHelper
    {
        public static bool IsAvailableWeight(this EntityContext context, double weight)
        {
            if (context.PermissibleMaximumWeigth >= weight)
            {
                return true;
            }

            return false;
        }
    }
}

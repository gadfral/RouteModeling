using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouteModelingCore.Context.EntityContext;
using RouteModelingCore.Entities;

namespace RouteModelingCore.Helpers;

public static class DimensionHelper
{
    public static bool IsEqual(Dimensions first, Dimensions second)
    {
        if (first.Equals(second))
            return true;

        return false;
    }

    public static bool IsAvailableDimensions(this EntityContext context, Dimensions dimensions)
    {
        if (context.Dimensions.Height >= dimensions.Height &&
            context.Dimensions.Length >= dimensions.Length &&
            context.Dimensions.Width >= dimensions.Width)
        {
            return true;
        }

        return false;
    }
}
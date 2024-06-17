using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouteModelingCore.Context;
using RouteModelingCore.Context.EntityContext;
using RouteModelingCore.Entities;

namespace RouteModelingCore.Helpers
{
    public static class ContextHelper
    {
        public static EntityContext? GetContext(AutoType autoType)
        {
            return autoType switch
            {
                AutoType.None => null,
                AutoType.Moto => AutoContext.MotoContext,
                AutoType.Car => AutoContext.CarContext,
                AutoType.Truck => AutoContext.TrackContext,
                _ => throw new ArgumentOutOfRangeException(nameof(autoType))
            };
        }

        public static List<EntityContext> GetContextByParams(Freight freight)
        {
            List<EntityContext> contexts = new List<EntityContext>();

            if (Context.AutoContext.MotoContext.IsAvailableDimensions(freight.Dimensions) && 
                Context.AutoContext.MotoContext.IsAvailableWeight(freight.Weight))
                contexts.Add(Context.AutoContext.MotoContext);

            if (Context.AutoContext.CarContext.IsAvailableDimensions(freight.Dimensions) &&
                Context.AutoContext.CarContext.IsAvailableWeight(freight.Weight))
                contexts.Add(Context.AutoContext.CarContext);

            if (Context.AutoContext.TrackContext.IsAvailableDimensions(freight.Dimensions) && 
                Context.AutoContext.TrackContext.IsAvailableWeight(freight.Weight))
                contexts.Add(Context.AutoContext.TrackContext);

            return contexts;

        }
    }
}

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

        public static EntityContext GetContextByParams(Freight freight)
        {
            throw new NotImplementedException();
        }
    }
}

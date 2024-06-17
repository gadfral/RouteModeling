using RouteModelingCore.Context.EntityContext;
using RouteModelingCore.Entities;
using RouteModelingCore.Helpers;

namespace RouteModelingCore;

public static class RouteCalculator
{
    public static List<Route> CalculateRoutes(Freight freight)
    {
        var autoContexts = new List<EntityContext>();
        var autoContext = ContextHelper.GetContext(freight.AutoType);

        if (autoContext is not null)
        {
            autoContexts = new List<EntityContext>() { autoContext };
        }

        if (autoContext is null)
        {
            autoContexts = ContextHelper.GetContextByParams(freight);
        }

        return CalculateRoutes(freight, autoContexts);
    }

    private static List<Route> CalculateRoutes(Freight freight, List<EntityContext> autoContexts)
    {
        return autoContexts.ConvertAll(autoContext =>
        {
            var distance = DistanceHelper.CalculateDistance(freight.Way.From, freight.Way.To) / 1000;

            var time = distance / autoContext.Speed;
            decimal fullPrice = autoContext.Price.FullPrice * (decimal)(distance / 10);

            return new Route
            {
                FullPrice = fullPrice,
                Time = time * 60,
                СurrencyCode = "RUB",
                AutoName = autoContext.AutoType.GetName(),
            };
        });
    }
}
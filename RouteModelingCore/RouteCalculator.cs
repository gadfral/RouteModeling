using RouteModelingCore.Entities;
using RouteModelingCore.Helpers;

namespace RouteModelingCore;

public static class RouteCalculator
{
    public static Route CalculateRoute(Freight freight)
    {
        var autoContext = ContextHelper.GetContext(freight.AutoType);

        if (autoContext is null)
        {
            autoContext = ContextHelper.GetContextByParams(freight);
        }

        var distance = DistanceHelper.CalculateDistance(freight.Way.From, freight.Way.To);

        var time = distance / autoContext.Speed;
        decimal fullPrice = autoContext.Price.FullPrice * (decimal)(distance / 1000);

        return new Route
        {
            FullPrice = fullPrice,
            Time = time,
            СurrencyCode = "RUB",
        };
    }

    

}
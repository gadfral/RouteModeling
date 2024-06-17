using RouteModelingCore.Entities;
using RouteModelingCore.Helpers;

namespace RouteModelingCore;

public static class RouteCalculator
{
    public static Route CalculateRoute(Freight freight)
    {
        var speed = RandomCalc.RandomSpeed(AutoType.PassengerCar);

        var distance = DistanceHelper.CalculateDistance(freight.Way.From, freight.Way.To);

        var price = RandomCalc.RandomPrice(AutoType.PassengerCar);

        var time = speed * distance;
        decimal fullPrice = price * (decimal)(distance / 1000);

        return new Route
        {
            FullPrice = fullPrice,
            Time = time,
            СurrencyCode = "RUB",
        };
    }

}
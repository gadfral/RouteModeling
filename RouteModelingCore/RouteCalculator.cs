using RouteModelingCore.Entities;

namespace RouteModelingCore;

public static class RouteCalculator
{
    public static Route CalculateRoute(Freight freight)
    {
        var speed = RandomCalc.RandomSpeed(AutoType.PassengerCar);
        var way = RandomCalc.RandomWay();
        var price = RandomCalc.RandomPrice(AutoType.PassengerCar);

        var time = speed * way;
        decimal fullPrice = price * (decimal)(way / 1000);

        return new Route
        {
            FullPrice = fullPrice,
            Time = time,
            СurrencyCode = "RUB",
        };
    }

}
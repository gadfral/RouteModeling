using RouteModelingCore.Entities;

namespace RouteModelingCore;

public static class RouteCalculator
{
    public static Route CalculateRoute(Freight freight)
    {
        var speed = RandomCalc.RandomSpeed();
        var way = RandomCalc.RandomWay();
        var price = RandomCalc.RanmdonPrice();

        throw new NotImplementedException();
    }

}
using RouteModelingApp.Entities;
using RouteModelingCore.Entities;

namespace RouteModelingApp.Mapper
{
    public static class ModelMapper
    {
        public static RouteModel MapToModel(this RouteModelingCore.Entities.Route route) => new RouteModel
        {
            FullPrice = route.FullPrice,
            Time = route.Time,
            СurrencyCode = route.СurrencyCode,
        };

        public static Freight MapToFreight(this GetRouteQuery query) => new Freight
        {
            Dimensions = query.Dimensions,
            Way = query.Way,
            AutoType = query.AutoType,
            Weight = query.Weight,
            Valuation = query.Valuation,
        };
    }
}

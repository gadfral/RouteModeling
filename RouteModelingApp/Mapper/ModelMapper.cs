using RouteModelingApp.Entities;

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
    }
}

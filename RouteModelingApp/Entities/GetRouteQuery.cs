using RouteModelingCore.Entities;

namespace RouteModelingApp.Entities
{
    public class GetRouteQuery
    {
        public AutoType AutoType { get; set; }

        public Dimensions Dimensions { get; set; }

        //public Valuation Valuation { get; set; }

        public Way Way { get; set; }

        public double Weight { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouteModelingCore.Entities;

namespace RouteModelingCore.Context
{
    public static class AutoContext
    {
        private static readonly EntityContext.EntityContext _motoContext = new EntityContext.EntityContext
        {
            Speed = 130, 
            Dimensions = new Dimensions
            {
                Height = 40,
                Width = 30, 
                Length = 20,
            },
            Price = new Price
            {
                FullPrice = 50,
            },
            PermissibleMaximumWeigth = 15,
            AutoType = AutoType.Moto,
        };

        private static readonly EntityContext.EntityContext _carContext = new EntityContext.EntityContext
        {
            Speed = 100,
            Dimensions = new Dimensions
            {
                Height = 150,
                Width = 100,
                Length = 50,
            },
            Price = new Price
            {
                FullPrice = 250,
            },
            PermissibleMaximumWeigth = 200,
            AutoType = AutoType.Car,
        };

        private static readonly EntityContext.EntityContext _trackContext = new EntityContext.EntityContext
        {
            Speed = 70,
            Dimensions = new Dimensions
            {
                Height = 300,
                Width = 200,
                Length = 200,
            },
            Price = new Price
            {
                FullPrice = 600,
            },
            PermissibleMaximumWeigth = 3500,
            AutoType = AutoType.Truck,
        };

        public static EntityContext.EntityContext CarContext => _carContext;

        public static EntityContext.EntityContext TrackContext => _trackContext;

        public static EntityContext.EntityContext MotoContext => _motoContext;
    }
}

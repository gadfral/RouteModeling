using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouteModelingCore.Entities;

namespace RouteModelingCore
{
    public static class RandomCalc
    {
        /// <summary>
        /// Путь в метрах
        /// </summary>
        /// <returns></returns>
        public static double RandomWay() => new Random().Next(1000, 10000);

        /// <summary>
        /// Скорость в км/ч
        /// </summary>
        /// <returns></returns>
        public static int RandomSpeed(AutoType type) => type switch
        {
            AutoType.PassengerCar => new Random().Next(1000, 10000),
            AutoType.Suv => new Random().Next(1000, 1000),
            AutoType.Сargo => new Random().Next(1000, 1000),
            AutoType.Truck => new Random().Next(1000, 1000),
            _ => throw new ArgumentOutOfRangeException(nameof(type))
        };

        /// <summary>
        /// Цена за км
        /// </summary>
        /// <returns></returns>
        public static decimal RandomPrice(AutoType type) => type switch
        {
            AutoType.PassengerCar => new Random().Next(1000, 10000),
            AutoType.Suv => new Random().Next(1000, 1000),
            AutoType.Сargo => new Random().Next(1000, 1000),
            AutoType.Truck => new Random().Next(1000, 1000),
            _ => throw new ArgumentOutOfRangeException(nameof(type))
        };
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static int RandomSpeed() => new Random().Next(15, 80);

        /// <summary>
        /// Цена за км
        /// </summary>
        /// <returns></returns>
        public static decimal RanmdonPrice() => new Random().Next(100, 500);
    }
}

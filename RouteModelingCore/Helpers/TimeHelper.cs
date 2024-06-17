using RouteModelingCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteModelingCore.Helpers
{
    public static class TimeHelper
    {
        public static string GetSimpleTime(double minute)
        {
            if (minute < 1)
            {
                var seconds = minute * 60;

                return $"{seconds:F} секунд(ы)";
            }

            if (minute > 60)
            {
                var hour = minute / 60;

                return $"{hour:F} час(а/ов)";
            }

            return $"{minute:F} минут(ы)",
        }
    }
}

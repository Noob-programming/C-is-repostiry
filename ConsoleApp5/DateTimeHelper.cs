using System;

namespace ConsoleApp5
{

    /// <summary>
    /// is help use for day of work and weekend :)
    /// </summary>
    public static class DateTimeHelper
    {
        public static bool IsWeekend(this DateTime dt)
        {
            return dt.DayOfWeek == DayOfWeek.Friday || dt.DayOfWeek == DayOfWeek.Saturday;
        }

        public static bool IsWorkDay(this DateTime dt)
        {
            return !IsWeekend(dt);
        }
    }
}
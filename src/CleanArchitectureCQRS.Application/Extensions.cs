using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CleanArchitectureCQRS.Application
{
    public static class Extensions
    {

        public static bool BeAValidDate(this string date)
        {            
            return true;
        }
    }
    public static class Commons
    {

        public static bool BeAValidDate(string date)
        {
            return DateTime.TryParseExact(date, "yyyy-MM-dd",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
        }
    }
}

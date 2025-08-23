using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GlobalNewsNetwork.Globally
{
    public static class clsGlobalMethods
    {
        public static string GetDifferenceBetweemDates(DateTime FirstDate,
            DateTime SecondDate)
        {
            TimeSpan DifferenceDates = SecondDate - FirstDate;

            if (DifferenceDates.TotalDays >= 365)
                return "منذ " + ((int)(DifferenceDates.TotalDays / 365)).ToString() + " سنوات";

            else if (DifferenceDates.TotalDays >= 30)
                return "منذ " + ((int)(DifferenceDates.TotalDays / 30)).ToString() + " شهور";

            else if (DifferenceDates.TotalDays >= 7)
                return "منذ " + ((int)(DifferenceDates.TotalDays / 7)).ToString() + " أسابيع";

            else if (DifferenceDates.TotalHours >= 24)
                return "منذ " + ((int)(DifferenceDates.TotalHours / 24)).ToString() + " أيام";

            else if (DifferenceDates.TotalMinutes >= 60)
                return "منذ " + ((int)(DifferenceDates.TotalMinutes / 60)).ToString() + " ساعات";

            else if (DifferenceDates.TotalSeconds >= 60)
                return "منذ " + ((int)(DifferenceDates.TotalSeconds / 60)).ToString() + " دقائق";

            else
                return "منذ " + DifferenceDates.TotalSeconds + " ثواني";
        }
    }
}

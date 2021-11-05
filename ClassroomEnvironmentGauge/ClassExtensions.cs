using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class ClassExtensions {

    public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek) {
        int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
        return dt.AddDays(-1 * diff).Date;
    }

    //public static string[] DayLetters = { "S", "M", "T", "W", "T", "F", "S" };
    public static string DayLetter(this DateTime dt) {
        return dt.DayOfWeek.ToString().Substring(0, 1);
    }

    public static string VeryShortDateString(this DateTime dt) {
        return dt.Month.ToString() + "/" + dt.Day.ToString();
    }

}


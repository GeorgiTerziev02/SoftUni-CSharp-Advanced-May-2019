using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem5DateModifier
{
    public class DateModifier
    {
        public static void DateDiff(string date1,string date2)
        {
            int[] d1 = date1
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] d2 = date2
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            DateTime firstDay = new DateTime ( d1[0], d1[1], d1[2] );
            DateTime secondDay = new DateTime ( d2[0], d2[1], d2[2] );

            TimeSpan diff = firstDay - secondDay;
            Console.WriteLine(Math.Abs(diff.TotalDays));
        }
    }
}

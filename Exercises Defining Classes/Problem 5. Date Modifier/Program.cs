﻿using System;

namespace Problem5DateModifier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            DateModifier.DateDiff(date1, date2);
        }
    }
}

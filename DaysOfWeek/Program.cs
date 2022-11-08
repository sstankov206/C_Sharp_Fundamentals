/* You are given a date in format day-month-year
 * Calculate and print the day of week in English
 * 
 * Examples:
 * 
 * 18-04-2016 -> Monday
 * 27-11-1996 -> Wednesday
 * 
 * solution by me, sstankov.
 */

using System;
using System.Text;
using System.Globalization;

class Program
{
    static void Main()
    {
        //reading date in d-M-yyyy format, from console input:
        string dateString = Console.ReadLine();

        DateTime date = DateTime.ParseExact(dateString, "d-M-yyyy",
            CultureInfo.InvariantCulture);

        Console.WriteLine(date.DayOfWeek);
    }
}



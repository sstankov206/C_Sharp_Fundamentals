/* Write program to enter an integer number of centuries and convert it to 
 years, days, hours and minutes.

 Examples:
- Input: 1
- Output: 1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes

 Hints:
- Use appropriate data type to fit the result after each data conversion.
- Assume that a year has 365.2422 days at average (the Tropical year).

 solution by me, sstankov
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        int centuries = int.Parse(Console.ReadLine()); //determined by user input

        int years = (int)(centuries * 100); //centruries -> years
        int days = (int)(years * 365.2422); //years -> days

        int hours = (int)(days * 24); //days -> hours
        int minutes = (int)(hours * 60); //hours -> minutes

        Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours" +
            " = {4} minutes", centuries, years, days, hours, minutes); //output
    }
}
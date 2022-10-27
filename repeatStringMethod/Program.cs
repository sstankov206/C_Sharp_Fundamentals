/* Create a method that repeats a string n number of times.
 * 
 * solution by me, sstankov
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine(); //input determined by console
        int n = int.Parse(Console.ReadLine()); //# of times string will be repeated

        RepeatString(input, n); //invoking the 'RepeatString' method, which will
        //repeat the string by 'n' # of times.

    }

    static string RepeatString(string stringToRepeat, int times)
    {
        string result = "";
        for (int i = 0; i < times; i++)
        {
            result += stringToRepeat;
        }

        return result;
    }
}


/* Create a method that prints the sign of an integer number 'n'
 * 
 * solution by me, sstankov
 */

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); //integer 'n' determined via input
        PrintSign(n); //calling the method

    }

    //creating the method that prints the sign of the integer:
    static void PrintSign(int n)
    {
        if (n > 0)
        {
            Console.WriteLine($"The number {n} is positive.");
        }

        else if (n < 0)
        {
            Console.WriteLine($"The number {n} is negative.");
        }

        else
        {
            Console.WriteLine($"The number {n} is negative");

        }
    }
}

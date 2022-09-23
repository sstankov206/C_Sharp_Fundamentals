/* Write a program that prints the numbers 1 through N on the console.
The number N must be read from the standard input.

A For Loop MUST be used */

//Solution by me, sstankov.

using System;

class Program
{
    static void Main()
    {
        int i = 1;
        int n = int.Parse(Console.ReadLine()); //user determines value of N
        //via console input

        for (i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

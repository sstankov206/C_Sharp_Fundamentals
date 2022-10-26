/* Create a method for printing triangles as shown below:
 * 
 * INPUT: 3
 * 
 * OUTPUT: 1
 *         1 2
 *         1 2 3
 *         1 2
 *         1
 *         
 * solution by me, sstankov
 */

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // 'n' via input
        PrintTriangle(n); //calling the method, printing triangle

    }

    static void PrintTriangle(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            PrintNumbersFrom1(i);
        }

        for (int i = n - 1; i > 0; i--)
        {
            PrintNumbersFrom1(i);
        }
    }

    static void PrintNumbersFrom1(int to)
    {
        for (int i = 1; i <= to; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }
}


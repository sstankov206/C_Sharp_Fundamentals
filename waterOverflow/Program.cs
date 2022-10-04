/*  You have a water tank with capacity of 255 liters. On the next 'n' lines,
 you will receive liters of water, which you have to pour in your tank. If
 the capacity is not enough, print "Insufficient capacity!" and continue
 reading the next line. On the last line, print the liters in the tank.

 INPUT:
- On the first line, you will receive 'n' - the number of lines, which will
follow
- On the next 'n' lines - you receive quantities of water, which you have to
pour in the tank.

 OUTPUT:
- Every time you do not have enough capacity in the tank to pour the given
liters, print:
"Insufficient capacity!"
- On the last line, print only the liters in the tank.

 CONSTRAINTS:
- 'n' will be in the interval [1...20]
- liters will be in the interval[1...1000]

solution by me, sstankov
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // 'n' = number of lines

        int totalLiters = 0; //will be used to store total liters in the tank

        for (int i = 0; i < n; i++)
        {
            int liters = int.Parse(Console.ReadLine());

            if (totalLiters + liters > 255)
            {
                Console.WriteLine("Insufficient capacity!");
            }

            else
            {
                totalLiters += liters;
            }
        }
        Console.WriteLine(totalLiters);
    }
}
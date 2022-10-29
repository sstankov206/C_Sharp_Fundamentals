/* Write a method to print the smallest of three integer numbers.
 * Use appropriate name for the method.
 * 
 * Examples:
 * 
 * INPUT:  2
 *         5
 *         3
 *
 * OUTPUT: 2
 * 
 * solution by me, sstankov.
 */

using System;

class Program
{
    static void Main()
    {   //input:
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        //invoking the method to return the smallest number:
        int min = ReturnMinNum(num1, num2, num3);
        Console.WriteLine(min);//ouput
    }

    static int ReturnMinNum(int a, int b, int c)
    {//comparing all numbers to find the smallest integer:
        return Math.Min(Math.Min(a, b), c); //returns the smallest number
    }
}

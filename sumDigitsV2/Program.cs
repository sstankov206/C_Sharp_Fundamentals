/* You will be given a single integer. Your task is to find the sum of its
digits.

   Examples:

   245678 = 32
   97561 = 28
   543 = 12, etc.

This is the same task as the 'sumDigits' problem, but here the solution
uses a for loop instead of a while loop.

   solution by me, sstankov */

using System;

class Program
{
    static void Main(string[] args)
    {
        string num = (Console.ReadLine()); //integer determined by user input

        int sum = 0; //will be used to store the sum of the digits

        for (int i = 0; i < num.Length; i++)
        {
            sum += int.Parse(num[i].ToString());
            //the 'sum' (of our digits) will increase with each
            //iteration of 'i', where 'i' represents the iteration of our
            //integer from input
        }

        Console.WriteLine(sum);
    }


}

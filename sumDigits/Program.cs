/* You will be given a single integer. Your task is to find the sum of its
digits.

   Examples:

   245678  = 32
   97561 = 28
   543 = 12, etc.

   solution by me, sstankov */

using System;

class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        int sum = 0; //will be used to store the sum of the digits

        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }

        Console.WriteLine(sum);
    }


}
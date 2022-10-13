/*  Read four integer numbers. Add first to the second, divide (integer) the sum 
  by the third number and multiply the result by the fourth number. 
  Print the result.

  Examples:
- Input: 10 20 3 3
- Output: 30

  solution by me, sstankov.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter 1st number");
        int first = int.Parse(Console.ReadLine()); //input for 1st integer

        Console.WriteLine("Please enter 2nd number");
        int second = int.Parse(Console.ReadLine()); //input for 2nd integer

        Console.WriteLine("Please enter 3rd number");
        int third = int.Parse(Console.ReadLine()); //input for 3rd integer

        Console.WriteLine("Please enter 4th number");
        int fourth = int.Parse(Console.ReadLine()); //input for 4th integer

        int sum = 0; //will store the sum in this variable
        int output = 0; //will use this for the final result

        sum = first + second;
        output = (sum / third) * fourth;

        Console.WriteLine($"Output is: {output}");

    }
}
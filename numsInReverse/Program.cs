/* 
  Read 'n' numbers and print them in reverse order.

  solution by me, sstankov.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        //reading 'n' from input:
        int n = GetNumber();

        //creating the array with size of 'n':
        int[] numbers = new int[n];

        //setting 'number' to the corresponding index:
        for (int i = 0; i < n; i++)
        {
            int number = GetNumber();


            numbers[i] = number;
        }
        
        //printing the array in reverse order:
        for (int j = numbers.Length - 1; j >= 0; j--)
        {
            Print(numbers[j] + " "); //output
        }

    }

    public static int GetNumber()
    {
        var number = int.Parse(Console.ReadLine());
        return number;
    }

    public static void Print(string value)
    {
        Console.WriteLine(value);
    }

}

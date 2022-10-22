/* Write a program, which prints all unique pairs in an array of integers 
 whose sum is equal to a given number.

Examples:

- Input: 1 7 6 2 19 23
         8

- Output: 1 7
          6 2

solution by me, sstankov
*/

using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //creating the array from input:
        var array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        //will store the given number here:
        int given = int.Parse(Console.ReadLine());

        //iterating through all the elements:
        for (int i = 0; i < array.Length; i++)
        {
            //iterating from 2nd element to the end of the array:
            for (int j = i + 1; j < array.Length; j++)

                //checking for sum of pairs to be equal to the 'given' number:
                if (array[i] + array[j] == given)
                {
                    Console.WriteLine(array[i] + " " + array[j]); //output
                }

        }

    }
}




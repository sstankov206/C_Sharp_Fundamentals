/* Write a program that determines if there exists an element in the array such 
 * that the sum of the elements on its left is equal to the sum of the elements on 
 * its right (there will never be more than 1 element like that). If there are no 
 * elements to the left/ right, their sum is considered to be 0. Print the index
 * that satisfies the required condition or "no" if there is no such index.
 * 
 * Examples:
 * 
 * - INPUT: 1 2 3 3
 * - OUTPUT: 2
 * 
 * - INPUT: 1 2
 * - OUTPUT: no
 * 
 * - INPUT: 10 5 5 99 3 4 2 5 1 1 4
 * - OUTPUT: 3
 * 
 * solution by me, sstankov
 */

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        //creating array with elements via input/console:
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        //going thorugh each element:
        for (int i = 0; i < array.Length; i++)
        {
            int leftSum = 0; //will store sum of all elements on left of array
            int rightSum = 0; //will store sum of all ements on the right of array

            //iterating through left side:
            for (int j = 0; j < i; j++)
            {
                leftSum += array[j]; //summing the left elements
            }

            //iterating through right side:
            for (int k = i + 1; k < array.Length; k++)
            {
                rightSum += array[k]; //summing the right elements
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine(i);
                return;
            }
        }
        Console.WriteLine("no");//output when condition is not met
    }
}
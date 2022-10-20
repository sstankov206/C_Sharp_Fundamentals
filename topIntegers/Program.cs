/* Write a program to find all the top integers in an array. A top integer is 
  an integer which is BIGGER than all the elements to its right.
 
  Examples:

 - INPUT: 1 4 3 2
 - OUTPUT: 4 3 2

 - INPUT: 14 24 3 19 15 17
 - OUTPUT: 24 19 17

 solution by me, sstankov
 */

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        //creating an array of integers from input:
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        //traversing the elements of the array:
        for (int i = 0; i < array.Length; i++)
        {
            //boolean variable that will determine the biggest integer:
            bool isBiggestInteger = true;

            //traversing the array starting with the 2nd element:
            for (int j = i + 1; j < array.Length; j++)
            {
                //checking indexes to find the bigger integer:
                if (array[i] <= array[j])
                {
                    isBiggestInteger = false;
                    break;
                }
            }

            //if biggest integer, print:
            if (isBiggestInteger)
            {

                Console.WriteLine(array[i] + " "); //output
            }
        }
    }
}
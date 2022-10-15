/* Read an array of strings (space separated values), reverse it and print its elements:
 * 
 * Examples:
 * - Input: -1 hi ho w
 * - Output: w ho hi -1
 *
 *solution by me, sstankov
 *
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        //creating a string 'input' which will store elements of the array:
        string input = Console.ReadLine(); //Ex: 1 2 3 4 5

        //splits elements of the 'input' string by space & puts them in array:
        var array = input.Split();

        //reversing the array:
        for (int index = array.Length - 1; index >= 0; index--)
        {
            Console.Write(array[index] + " "); //ouput, seperated with space.
        }
    }
}
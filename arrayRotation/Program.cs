/* Write a program that receives an array and number of rotations you 
  have to perform (first element goes at the end) Print the resulting array.
  
  Examples:
  - Input: 51 47 32 61 21
           2
          
  - Output: 32 61 21 51 47
  
  solution by me, sstankov
 */

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        //receiving input via console and placing it in an array:
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        //determining the number of rotations via input:
        int n = int.Parse(Console.ReadLine());

        //iterating the array 'n' times:
        for (int i = 0; i < n; i++)
        {
            int firstElement = array[0]; //Ex: 32

            //temp array that will store new numbers after rotating:
            int[] temp = new int[array.Length]; //will have the same lenght as the original array

            for (int j = 1; j < array.Length; j++)
            {
                temp[j - 1] = array[j];
            }

            //assigning the rotated numbers to the array:
            temp[temp.Length - 1] = firstElement; //shifting 1st element to the last place in the array
            array = temp; //original array now has the elements of the temp array (rotated numbers)
        }
        //output:
        Console.WriteLine(String.Join("", array));

    }
}

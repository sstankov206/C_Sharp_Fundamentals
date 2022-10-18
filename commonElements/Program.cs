/* Write a program, which prints common elements in two arrays.
  You have to compare the elements of the second array to the
  elements of the first.
  
  Examples:
- Input: Hey hello 2 4
         10 hey 4 hello

- Output: 4 hello
 
  solution by me, sstankov.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        //creating the 2 arrays with elements based on input:
        string[] firstArray = Console.ReadLine().Split(); //input for 1st array
        string[] secondArray = Console.ReadLine().Split(); //input for 2nd array

        //creating variable that will store common elements:
        string commonElements = string.Empty;

        //comparing elements of 2nd array against those of the 1st array:
        for (int index = 0; index < secondArray.Length; index++)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (secondArray[index] == firstArray[i])
                {
                    //adding the common elements to the corresponding string:
                    commonElements += (firstArray[i] + " ");
                }
            }

        }

        //output
        Console.WriteLine(commonElements);
    }
}
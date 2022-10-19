/* Write a program which creates 2 arrays. You will be given an integer n.
 On the next n lines you get 2 integers. Form 2 arrays as shown below.

 Examples:

- Input:
 4
 1 5
 9 10
 31 81
 41 20

- Output:
1 10 31 20
5 9  81 41

solution by me, sstankov
*/

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        //determining how many lines of integers to have, via input:
        int n = int.Parse(Console.ReadLine());

        //creating 2 arrays with the given length of 'n':
        int[] array1 = new int[n];
        int[] array2 = new int[n];


        for (int i = 0; i < n; i++)
        {
            //checking if the line within the input is even:
            int[] currentLine = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (i % 2 == 0) //if the line is even:
            {
                array1[i] = currentLine[0]; //add 1st element of the 1st line to the current line
                array2[i] = currentLine[1]; //add 2nd element of the 2nd line to the current line
            }
            else //if the line is not even:
            {
                array1[i] = currentLine[1]; //add 2nd element of the 1st line to the current line
                array2[i] = currentLine[0]; //add 1st element of the 2nd line to the current line


            }
        }

        //output:
        Console.WriteLine(string.Join(" ", array1));
        Console.WriteLine(string.Join(" ", array2));
    }
}

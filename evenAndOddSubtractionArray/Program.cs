/* Write a program that calculates the difference between the sum of the even 
 * and the sum of the odd numbers in an array.
 * 
 * EXAMPLES:
 * 
 * - INPUT: 1 2 3 4 5 6
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
        //1. Create array of numbers via input
        //2. sum even numbers
        //3. sum odd numbers
        //4. return result of even - odd

        //creating array via input:
        var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int even = 0; //will store sum of even numbers
        int odd = 0; // will store sum of odd numbers

        int result = 0; //will store the result

        for (int i = 0; i < array.Length; i++) //traversing the array
        {
            if (array[i] % 2 == 0) //checking for even numbers
            {
                even += array[i]; //adding even numbers to 'even' sum
            }

            if (array[i] % 2 != 0) //checking for odd numbers
            {
                odd += array[i]; //adding odd numbers to 'odd' sum
            }

            result = even - odd; //subracting the 'even' sum from 'odd' sum
        }
        Console.WriteLine(result); //output
    }
}


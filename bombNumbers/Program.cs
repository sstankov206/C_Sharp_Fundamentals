/*Write a program that reads a sequence of numbersand a special bomb number with 
 * a certain power. Your task is to detonate every occurrence of the special bomb 
 * numberand according to its power -his neighbors from left and right. Detonations 
 * are performed from left to right and all detonated numbers disappear. Finally 
 * print the sum of the remaining elements in the sequence.
 * 
 * Examples:
 * 
 * INPUT:           1 2 2 4 2 2 2 9
 *                  4 2
 * OUTPUT:          12
 *
 *Comments: Special number is 4 with power 2. After the detonation we are left
 *with the sequence [1,2,9] with sum 12.
 *
 *solution by me, sstankov.
 */

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {   //creating the list from input:
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

        //creating array with data about the bomb:
        int[] bombData = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int specialBombNumber = bombData[0]; //Ex: 4 2 -> bomb is 4.
        int bombPower = bombData[1];  //Ex: 4 2 -> bomb's power is 2.

        int bombIndex = list.IndexOf(specialBombNumber);

        while (bombIndex != -1)
        {
            //calculating numbers to detonate on the left side of the bomb's special number:
            int leftNumbers = bombIndex - bombPower;

            //calculating numbers to detonate on the right side of the bomb's special number:
            int rightNumbers = bombIndex + bombPower;

            //validation check:
            if (leftNumbers < 0)
            {
                leftNumbers = 0;
            }
            if (rightNumbers > list.Count - 1)
            {
                rightNumbers = list.Count - 1;
            }

            //removing numbers to the left & right + the bomb:
            list.RemoveRange(leftNumbers, rightNumbers - leftNumbers + 1);

            //getting index of next bomb (if there are more than 1 bombs):
            bombIndex = list.IndexOf(specialBombNumber);
        }

        int sum = list.Sum();
        Console.WriteLine(sum); //output
    }
}


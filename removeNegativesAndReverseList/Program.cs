/* Problem: Read a list of integers, remove all negative numbers from it.
 * ▪ Print the remaining elements in reversed order.
 * ▪ In case of no elements left in the list, print "empty".
 * 
 * Examples:
 * 
 * INPUT:   7  -2 -10 1
 * OUTPUT:   1  7
 * 
 * solution by me, sstankov.
 */

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //creating a list of integers, via input:

        List<int> list = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

        //iterating through the list, removing the negative numbers:
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] < 0) //checks for negative #'s
            {
                list.RemoveAt(i--);
            }
        }

        list.Reverse(); //reverses the order of the list
        if (list.Count == 0)
        {
            Console.WriteLine("Empty"); //output if list is empty.
        }
        else
        {
            Console.WriteLine(String.Join(" ", list)); //prints the reversed list w/o negative #'s
        }

    }
}


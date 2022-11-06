/* Write a program that sums all numbers in a list in the following order:
 * first + last, first + 1 + last -1, first + 2 + last -2,...first + n, last –n
 * 
 * Examples:
 * 
 * INPUT:       1 2 3 4 5 
 * OUTPUT       6 6 3
 * 
 * INPUT:       1 2 3 4
 * OUTPUT:      5 5
 * 
 * solution by me, sstankov
 */

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        //invoking the method that holds the list:
        List<int> list = ReadIntListSingleLine();

        //output:
        Console.WriteLine(String.Join(" ", SumPairs(list)));
    }

    //creating a method that will hold the sum of pairs from the list:
    static List<int> SumPairs(List<int> numbers)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < numbers.Count / 2; i++) //for list length = even number
        {
            //add: current number + (last current number):
            result.Add(numbers[i] + numbers[numbers.Count - i - 1]);
        }
        if (numbers.Count % 2 == 1) //for list length = odd number
        {
            result.Add(numbers[numbers.Count / 2]); //adding the middle number
        }
        return result;
    }

    //creating a method that will hold the list, determined by console input:
    static List<int> ReadIntListSingleLine()
    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
        return list;
    }
}
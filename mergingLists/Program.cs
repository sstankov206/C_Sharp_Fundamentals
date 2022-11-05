/* You receive two lists with numbers. Print a result list, which contains the 
 * numbers from both of the lists.
 * 
 * If the length of the two lists are not equal, just add the remaining elements
 * at the end of the list:
 * 
 * Examples:
 * 
 * INPUT:       1 2 3 4 5
 *              6 7 8
 *              
 * OUTPUT:      1 6 2 7 3 8 4 5
 * 
 * solution by me, sstankov.
 */

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        //invoking the list method, creating 2 lists:
        var firstList = ReadIntListSingleLine();
        var secondList = ReadIntListSingleLine();

        //output:
        Console.WriteLine(String.Join(" ", MergeLists(firstList, secondList)));
    }

    //creating a method that will hold the list, determined via console input:
    static List<int> ReadIntListSingleLine()
    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
        return list;
    }

    //storing the bigger length between the two lists:
    static List<int> MergeLists(List<int> first, List<int> second)
    {
        int count = Math.Max(first.Count, second.Count);
        List<int> merged = new List<int>(); //creating the 3rd (merged) list

        for (int i = 0; i < count; i++)
        {
            if (first.Count > i)
            {
                merged.Add(first[i]);  //adding current element of 1st list to merged list
            }
            if (second.Count > i)
            {
                merged.Add(second[i]); //adding current element of 2nd list to merged list
            }
        }
        return merged;
    }
}


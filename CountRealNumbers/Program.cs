/* Read a list of integers and print them in ascending order,
 * along with their number of occurrences.
 * 
 * Examples:
 * 
 * INPUT:           8 2 2 8 2
 * OUTPUT:          2 -> 3
 *                  8 -> 2
 *
 * Problem must be solved using dictionaries.
 * 
 * solution by me, sstankov.
 */

using System;

class Program
{
    static void Main()
    {
        //input:
        double[] numbers = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();

        //creating the dictionary:
        var sortedDictionary = new SortedDictionary<double, int>();

        //iterate through all numbers in the input:
        foreach (double number in numbers)
        {
            //check if dictionary contains this number (key)
            if (sortedDictionary.ContainsKey(number)) 
            {
                sortedDictionary[number]++; //increase this number (key's) value
            }
            else //if the dictionary doesn't (already) contain this number (key):
            {
                sortedDictionary.Add(number, 1); //add this number (as a key), and increase the key's value
            }
        }

        //for each key/value pair in the sorted dictionary:
        foreach (var pair in sortedDictionary)
        {
            //print the output in the following format:

            Console.WriteLine(pair.Key + " -> " + pair.Value);
        }
    }
}
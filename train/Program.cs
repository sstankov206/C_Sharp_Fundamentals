/* You will be given a count of wagons in a train n. On the next nlines you will
  receive how many people are going to get on each wagon.
  At the end print the whole train and after that, on the next line, 
  the sum of the people in the train.

 Examples:
Input:
- 3
- 13
- 24
- 8

Output:
- 13 24 8
- 45

solution by me, sstankov */

using System;

class Program
{
    static void Main(string[] args)
    {
        //setting up 'n' number of wagons in the train via console/input:
        int n = int.Parse(Console.ReadLine());

        //creating array for the wagons with 'n' as length:
        int[] wagons = new int[n];

        //creating the sum of passengers; the sum will be stored here:
        int sum = 0;

        for (int index = 0; index < wagons.Length; index++)
        {
            //setting up # of passengers per wagon at corresponding index via input:
            wagons[index] = int.Parse(Console.ReadLine());

            //adding up the sum of passengers:
            sum = sum + wagons[index];

        }

        //printing the array of wagons containing passengers:
        Console.WriteLine(String.Join(" ", wagons));
        Console.WriteLine(sum); //output of the sum
    }
}
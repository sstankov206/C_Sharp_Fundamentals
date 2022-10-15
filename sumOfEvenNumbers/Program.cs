/* Read an array from the console and sum only the even numbers.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        //variable 'input' will store the numbers entered via console/input
        var input = Console.ReadLine();

        //numbers from 'input' will go in an array 'strings' and be split by a space
        string[] strings = input.Split(" ");
        

        //content from 'strings' array go in a new array 'numbers' which is integers based
        int[] numbers = new int[strings.Length];

        for (int i = 0; i < strings.Length; i++)
        {
            numbers[i] = int.Parse(strings[i]);
        }

        // 'sum' will store the total sum
        var sum = 0;
        for (int i = 0; i < numbers.Length; i++) 
        {
            if (numbers[i] % 2 == 0) //check for even numbers
            {
                sum = sum + numbers[i]; //adds them to the sum
            }
        }
        Console.WriteLine(sum); //output
    }
}

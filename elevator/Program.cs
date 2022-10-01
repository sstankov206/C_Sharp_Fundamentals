/* Calculate how many courses will be needed to elevate 'n' number of 
 persons by using an elevator of capacity of 'p' persons.
 The input holds two lines: the number of people 'n' and the capacity
 of the elevator 'p'.

 Examples:

 Input: 17
        3

 Output: 6     (5 courses * 3 people + 1 course * 2 people)

 solution by me, sstankov */

using System;

class Program
{
    static void Main(string[] args)
    {
        int numberOfPeople = int.Parse(Console.ReadLine()); //user input
        //determines the number of people are being transported

        int capacity = int.Parse(Console.ReadLine()); //user input determines
        //the capacity of the elevator

        int courses = (int)Math.Ceiling(numberOfPeople / (double)capacity);
        //using this expression to determine the number of courses needed
        //by the elevator.

        Console.WriteLine(courses); //output
    }
}


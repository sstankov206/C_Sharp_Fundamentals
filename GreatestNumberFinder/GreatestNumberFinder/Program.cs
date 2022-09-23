//Write a program that finds the greatest number by value
//among 5 given numbers. If statements MUST be used.

//Solution by me, sstankov.


using System;

class GreatestNumberFinder

{
    static void Main()
    {
        int number1, number2, number3, number4, number5;

        Console.WriteLine("Please enter 5 random numbers, the system will find the greatest number");

        Console.WriteLine("Enter the 1st number:");
        number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the 2nd number:");
        number2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the 3rd number:");
        number3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the 4th number:");
        number4 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the 5th number:");
        number5 = int.Parse(Console.ReadLine());
        //prompting the user to enter 5 random integers

        //if-else statement to determine the greatest number by value:
        if ((number1 > number2) && (number1 > number3) && (number1 > number4) && (number1 > number5))
        {
            Console.WriteLine("{0} is the greatest number", number1);
        }
        else if ((number2 > number1) && (number2 > number3) && (number2 > number4) && (number2 > number5))
        {
            Console.WriteLine("{0} is the greatest number", number2);
        }
        else if ((number3 > number1) && (number3 > number2) && (number3 > number4) && (number3 > number5))
        {
            Console.WriteLine("{0} is the greatest number", number3);
        }
        else if ((number4 > number1) && (number4 > number3) && (number4 > number2) && (number4 > number5))
        {
            Console.WriteLine("{0} is the greatest number", number4);
        }
        else if ((number5 > number1) && (number5 > number2) && (number5 > number3) && (number5 > number4))
        {
            Console.WriteLine("{0} is the greatest number", number5);
        }
        else
        {
            Console.WriteLine("Error: Please try again, using real numbers");
        }
    }
}
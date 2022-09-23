//Write a program that reads from the console three numbers of type 'int' and
//prints their sum.

//Solution by me, sstankov.

using System;

class SumOfThreeRandomNumbers
{
    static void Main()
    {
        int number1, number2, number3; //will use these variables to
        //determine the values of the 3 random numbers later, as assigned by
        //the user via console input.

  
        Console.WriteLine("Please enter a random number:");
        number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter 2nd random number:");
        number2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter 3rd random number:");
        number3 = int.Parse(Console.ReadLine());

        int sum = number1 + number2 + number3; //variable 'sum' will store the
                                               //value of the sum of the numbers.

        //determing the sum, and providing output to the user:
        Console.WriteLine("The sum of your numbers is: {0}", sum);
    }


}


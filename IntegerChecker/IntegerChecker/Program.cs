// Write a small program that checks whether a number is odd or even
// solution by me, sstankov

using System;

class IntegerChecker
{
static void Main()
    {
        int number1, remnant1; //declaring variables which will be used later, to check whether selected number is odd or even
        Console.WriteLine("Please type a whole number, to checke whether it's odd or even:");
        //Console message will print out, prompting the user to type a whole number

        number1 = Convert.ToInt32((Console.ReadLine())); //Console will take the number typed by the user and assign it's value to the variable 'number1'
        remnant1 = number1 % 2; //Calculation to check whether the number is even
        if (remnant1 == 0)
            Console.WriteLine("{0} is an even number. \n", number1); //if there is no remainder from the calculation, the number selected is even
        // and the console will print out that it is even, on a new line.
        else
            Console.WriteLine("{0} is an odd number. \n", number1); //otherwise, if there is a remainder from the calculation above, the number selected is odd
        //and the console will print out that it is odd, on a new line.
    }

}



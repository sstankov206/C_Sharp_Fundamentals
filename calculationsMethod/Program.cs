/* Write a program that receives a string on the first line (add, multiply, 
 * subtract, divide) and on the next two lines receives two numbers. Create 
 * four methods (for each calculation) and invoke the right one depending
 * on the command. The method should also print the result (needs to be void)
 *
 * Example:
 * 
 * INPUT: subtract
 *          5
 *          4
 * OUTPUT:  1
 *
 * solution by me, sstankov.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Type a command: add, multiply, subtract, divide");

        string command = Console.ReadLine(); //choice of command via input

        int a = int.Parse(Console.ReadLine()); //1st number
        int b = int.Parse(Console.ReadLine()); //2nd number


        //switch statement for each type of calculation
        switch (command)
        {
            case "add":
                Add(a, b);
                break;
            case "multiply":
                Multiply(a, b);
                break;
            case "subtract":
                Subtract(a, b);
                break;
            case "divide":
                Divide(a, b);
                break;
        }
    }
    //creating methods for each type of command, that will print the result

    private static void Add(int a, int b)
    {
        Console.WriteLine(a + b); //prints result of 'add'
    }

    private static void Multiply(int a, int b)
    {
        Console.WriteLine(a * b); //prints result of 'multiply'
    }

    private static void Divide(int a, int b)
    {
        Console.WriteLine(a / b); //prints result of 'divide'
    }

    private static void Subtract(int a, int b)
    {
        Console.WriteLine(a - b); //prints result of 'subtract'
    }
}

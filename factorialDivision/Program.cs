/* Read two integer numbers. Calculate factorial of each number. Divide the first
 * result by the second and print the division formatted to the second decimal point.
 * 
 * Examples:
 * 
 * INPUT:    5
 *           2
 *        
 * OUTPUT: 60.00   
 * 
 * solution by me, sstankov.
 *
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        //read the 2 integers from input:
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        //dividing the 1st result by the 2nd result, printing the result to 2nd dec. place:
        decimal result = CalculateFactorial(num1) / CalculateFactorial(num2);
        Console.WriteLine($"{result:f2}");

    }

    //creating a method that will calculate the factorial of each input number:
    static decimal CalculateFactorial(int num)
    {
        decimal factorial = 1;     //Ex: 5! = 1*2*3*4*5

        for (int i = 0; i < num; i++) //iterating through the numbers 1...num
        {
            factorial *= i; //obtaining the factorial of our num
        }

        return factorial;
    }
}

/*   Write a program, which sums the ASCII codes of 'n' characters and 
     prints the sum on the console.

     Input:

     - On the first line, you will receive 'n' - the number of lines which will
     follow
     - On the next 'n' lines - you will receive letters from the Latin alphabet

     Output:

     - Print the total sum in the following format:
     The sum equals: { totalSum}

     Constraints:

     - 'n' will be in the interval [1...20].
     -  The characters will always be either upper or lower-case letters
     from the English alphabet
     -  You will always receive one letter per line

    solution by me, sstankov. */

using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // 'n' determined by user input

        int sum = 0; //used to store the sum of the value of ASCII characters

        for (int i = 0; i < n; i++)
        {
            char letter = char.Parse(Console.ReadLine()); //for every iteration
            //of 'n' a new character will be read

            sum += letter; //the ASCII characters' value is added up and stored
            // in 'sum'
        }

        Console.WriteLine("The sum equals: " + sum); //ouput
    }


}
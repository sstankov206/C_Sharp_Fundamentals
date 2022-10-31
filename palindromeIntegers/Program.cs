/* A palindrome is a number which reads the same backward as forward, such as
 * 323 or 1001. Write a program which reads a positive integer numbers until 
 * you receive "End", for each number print whether the number is palindrome or not.
 * 
 * Examples:
 * 
 * INPUT:    123
 * OUTPUT:  False
 * 
 * solution by me, sstankov.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        //input read from console:
        string input = Console.ReadLine();

        //while the input DOESN'T equal "END", keep reading the input from console:
        while (input != "END")
        {
            Console.WriteLine(CheckForPalindrome(input).ToString().ToLower());
            //invoking the method that checks for palindromes
            input = Console.ReadLine();
        }
    }

    //creating method that will check if input is a palindrome:
    static bool CheckForPalindrome(string text)
    {
        var reversed = text.Reverse().ToArray();

        for (int i = 0; i < text.Length; i++)
        {
            if (!(reversed[i] == text[i])) //if the reversed input ISN'T equal to the input
                                           //return false, otherwise return true
            {
                return false;
            }
        }

        return true;
    }
}
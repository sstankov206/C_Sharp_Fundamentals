﻿/* Write a program, which emulates typing an SMS, following this guide:
  2 = 'abc', 3 = 'def', 4 = 'ghi', 5 = 'jkl', 6 = 'mno', 7 = 'pqrs',
  8 = 'tuv', 9 = 'wxyz', 0 = 'space'.

The program should receive an integer number first, representing the number
of characters in the string. On the next n lines it will receive numbers,
which represent a single character.
Following the guide, 2 becomes 'a', 22 becomes 'b' and so on. */


using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string two = "abc";
        string three = "def";
        string four = "ghi";
        string five = "jkl";
        string six = "mno";
        string seven = "pqrs";
        string eight = "tuv";
        string nine = "wxyz";

        string message = "";
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine(); // "22 -> b

            char current = input[0];

            switch (current)
            {
                case '2':
                    message += two[input.Length - 1];
                    break;
                case '3':
                    message += three[input.Length - 1];
                    break;
                case '4':
                    message += four[input.Length - 1];
                    break;
                case '5':
                    message += five[input.Length - 1];
                    break;
                case '6':
                    message += six[input.Length - 1];
                    break;
                case '7':
                    message += seven[input.Length - 1];
                    break;
                case '8':
                    message += eight[input.Length - 1];
                    break;
                case '9':
                    message += nine[input.Length - 1];
                    break;
            }

            Console.WriteLine(message); //output of the message


        }
    }
}
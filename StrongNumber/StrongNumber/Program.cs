/* Write a program to check if a given number is a strong number or not.
A number is a strong number if the sum of the Factorial of each digit is equal
to the number. For example, 145 is a strong number becase 1!+ 4!+ 5! = 145.
Print "yes" if the number is strong and "no" if the number is not strong.

solution by me, sstankov. */

using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int tempNum = num;
            string strNum = "";
            strNum += num;

            int sum = 0;

            for (int i = 0; i < strNum.Length; i++)
            {
                int currentDigit = tempNum % 10;
                tempNum = (tempNum - currentDigit) / 10;

                int factorial = 1;

                for (int x = 1; x <= currentDigit; x++)
                {
                    factorial *= x;
                }

                sum += factorial;
            }

            if (num == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}


    

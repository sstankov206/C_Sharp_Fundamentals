//Write a boolean statement, which checks whether a whole number is divisible
//by 5 and by 7, without a remainder. (Alternatively, one could check if the
//number is divisble by 35 as well).
//Solution by me, sstankov

using System;

namespace BooleanStatement
{
    class Program
    {
        static void Main()
        {
            int number1; //declaring a variable (number1) which will be used later;
            //its value will be determined by the input from the user
            Console.WriteLine("Please type a whole number. The system will check if it is divisible by 5 & 7");
            //console prompts user to type a whole number.

            number1 = Convert.ToInt32(Console.ReadLine());
            //the console will take the user's input and assign the value to
            //the variable (number1), converting from string to integer.

            if (number1 % 5 == 0 && number1 % 7 == 0)
                //calculating if the number provided by the user is divisible by
                //both 5 & 7.
            {
                bool divisible = true;
                Console.WriteLine("{0}, your number is divisible by 5 & 7. \n", divisible);
                //if true, the boolean statement will return 'true' on a new line
            }
            else
            {
                bool divisible = false;
                Console.WriteLine("{0}, your number is NOT divisible by 5 & 7. \n", divisible);
                //if true, the boolean statement will return 'false' on a new line
            }
            {

            }
        }
    }
}


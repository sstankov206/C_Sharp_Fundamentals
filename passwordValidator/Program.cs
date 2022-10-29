/* Write a program that checks if a given password is valid. 
 * Password rules are:
 * 
 * • 6 –10 characters (inclusive)
 * • Consists only of letters and digits
 * • Have at least 2 digits 
 * 
 * If a password is valid print "Password is valid". If it is not valid, 
 * for every unfulfilled rule print a message:
 * 
 * • "Password must be between 6 and 10 characters"
 * • "Password must consist only of letters and digits"
 * • "Password must have at least 2 digits"
 * 
 * Examples:
 * 
 * INPUT:   logIn
 * OUTPUT: Password must be between 6 and 10 characters
 *         Password must have at least 2 digits
 *         
 * Hints: Write a method for each rule.
 * 
 * solution by me, sstankov.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        //input for 'password' :
        string password = Console.ReadLine();

    }

    //creating a method that checks for a valid password:
    static void ValidatePassword(string text)
    {
        bool invalid = false; //boolean statement for when the password is invalid

        //checks if password is between 6 & 10 characters long:
        if (text.Length < 6 || text.Length > 10)
        {
            Console.WriteLine("Password must be between 6 and 10 characters");
            invalid = true;
        }

        //invoking method that checks if pasword doesn't meet criteria for only digits and numbers
        //returns message if password doesn't meet condition:
        if (CheckIfContainsOnlyDigitsAndLetters(text) == false)
        {
            Console.WriteLine("Password must consist only of letters and digits");
            invalid = true;
        }

        //ivoking method that checks for number of digits within the password.
        //retuns message if password doesn't meet condition:
        if (CountNumberOfDigits(text) < 2)
        {
            Console.WriteLine("Password must have at least 2 digits");
            invalid = true;
        }

        //returns message if password meets all conditions:
        if (invalid == false)
        {
            Console.WriteLine("Password is valid");
        }
    }

    //creating a method that checks for password using only digits and letters:
    static bool CheckIfContainsOnlyDigitsAndLetters(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            char currentChar = text[i]; //iterating thorugh each character of the password

            //checking if password DOESN'T contain only digits and lettes, using ASCII table values:
            if (!((currentChar >= 48 && currentChar <= 57)
                || (currentChar >= 65 && currentChar <= 90)
                || (currentChar >= 97 && currentChar <= 122))) ;
            {
                return false;
            }
        }
        return true;
    }

    //creating a method that checks for the number of digits within the password:
    static int CountNumberOfDigits(string text)
    {
        int digitsCount = 0;

        for (int i = 0; i < text.Length; i++) //traversing each character of the password
        {
            if (text[i] >= 48 && text[i] <= 57)
            {
                digitsCount++; //if the corresponding character is a digit, increment the  # of digits in the password
            }
        }
        return digitsCount;
    }
}

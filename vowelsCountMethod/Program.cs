/* Write a method that receives a single string and prints the count of the vowels. 
 * Use appropriate name for the method.
 * 
 * Example:
 * 
 * INPUT: Cats
 * OUTPUT: 1
 * 
 * solution by me, sstankov.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // input of text (coverting string to lower-case):
        string text = Console.ReadLine().ToLower();

        //invoking the method that counts vowels, prints the result:
        CountVowels(text);
    }

    //creating a method that wil handle the counting of vowels:
    static void CountVowels(string text)
    {
        int vowelsCounter = 0; //variable that stores the # of vowels
        //vowels: 'a', 'e', 'i', 'o', 'u'.

        for (int i = 0; i < text.Length; i++) //iterating through the string
        {
            switch (text[i]) //switch statement of each of the vowels
            {
                case 'a':
                    vowelsCounter++;
                    break;
                case 'e':
                    vowelsCounter++;
                    break;
                case 'i':
                    vowelsCounter++;
                    break;
                case 'o':
                    vowelsCounter++;
                    break;
                case 'u':
                    vowelsCounter++;
                    break;
            }
        }
        Console.WriteLine(vowelsCounter);
    }
}


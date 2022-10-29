/* Write a method that receives two characters and prints on a single line all
 * the characters in between them according to ASCII.
 * 
 * Example:
 * 
 * INPUT:   a
 *          d
 * 
 * OUTPUT:  b c
 * 
 * solution by me, sstankov.
 */

using System;

class Program
{
    static void Main(string[] args)
    {   //input 
        char start = char.Parse(Console.ReadLine());
        char end = char.Parse(Console.ReadLine());

        //invoking the method that prints the ASCII chars in range:
        PrintASCIIChars(start, end);
    }

    //creating method that prints ASCII chars in range of 'start' & 'end' : 
    static void PrintASCIIChars(char start, char end)
    {
        if (start < end)
        {
            for (int i = start + 1; i < end; i++)
            {
                //prints chars in between range on the same line, separated by space:
                Console.Write((char)i + " ");
            }
        }
        else
        {
            for (int i = end + 1; i < start; i++)
            {
                //prints chars in between range on the same line, separated by space:
                Console.Write((char)i + " ");
            }
        }
    }
}

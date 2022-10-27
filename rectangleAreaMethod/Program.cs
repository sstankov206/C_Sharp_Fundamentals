/* Create a method which returns rectangle area with given width and height
 * 
 * solution by me, sstankov
 */

using System;

class Program
{
    static void Main()
    {
        //invokes the method 'CalculateRectangleArea' to print area of
        //rectangle based on numbers provided from input

        Console.WriteLine(
            CalculateRectangleArea
            (int.Parse(Console.ReadLine()),
            int.Parse(Console.ReadLine())));
    }

    static int CalculateRectangleArea(int a, int b)
    {
        return a * b; //prints the area of the rectangle
    }
}

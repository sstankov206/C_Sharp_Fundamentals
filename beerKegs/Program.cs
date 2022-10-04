/* Write a program, which calculates the volume of 'n' beer kegs. You will
 receive in total 3 * n lines. Each three lines will hold information for a
 single keg. First up is the model of the keg, after that is the radius of
 the keg, and lastly is the height of the keg.

 Calculate the volume using the following formula: Pi * r^2 * h.

 At the end, print the model of the biggest keg.

 INPUT:
 - You will receive 3 * n lines. Each group of lines will be on a new line:
 - First: - model - string.
 - Second: - radius - floating-point number
 - Third: - height - integer number

 OUTPUT:
 - Print the model of the biggest keg.

 CONSTRAINTS:
 - 'n' will be in the interval [1...100]
 - The radius will be a floating-pint number in the interval [1...3.402823E+38]
 - The height will be an integer in the interval [1...2147483647]

 */

using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); //sets up # of lines (n)

        float maxVolume = float.MinValue;
        //will use this variable to check for the biggest volume (biggest keg)

        string biggestModel = String.Empty;
        //this variable will store which model has the biggest volume 

        for (int i = 0; i < n; i++)
        {
            string model = Console.ReadLine(); //sets up keg model via input
            //Keg 1, Keg 2, etc.

            float radius = float.Parse(Console.ReadLine());
            // sets up keg radius via input

            int height = int.Parse(Console.ReadLine());
            //sets up keg height via input

            double volume = Math.PI * Math.Pow(radius, 2) * height;
            //formula for the volume

            if (volume > maxVolume)
            {
                maxVolume = (float)(volume);
                biggestModel = model;
            }

        }
        Console.WriteLine(biggestModel);
    }
}
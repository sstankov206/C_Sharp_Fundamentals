//Write a program that reads from the console the radius "r" of a circle and
//prints its area and circumference.

//Solution by me, sstankov.

using System;

class CircleFormulas
{
    static void Main()
    {
        //formula for Area of circle is: A = Pi * r^2

        double pi = 3.14; //this variable will serve as the number Pi (3.14)

        Console.WriteLine("Please enter the Radius of the Circle");
        int r = int.Parse(Console.ReadLine());
        //variable 'r' will be used for the radius, the value of which
        //the user will determine via console input.

        double rSquared = Math.Pow(r, 2); //this calculation raises 'r' to the
        //power of 2, thus giving us the value of the radius, squared.

        double area = pi * rSquared; //calucating the area of the circle

        //The formula for Circumference of a circle is: C = 2 * Pi * r

        double circumference = 2 * (pi * r); //calculating the circumference

        Console.WriteLine("The area of your circle is: {0}, and its circumference is: {1}."
        , area, circumference);
        

    }

}
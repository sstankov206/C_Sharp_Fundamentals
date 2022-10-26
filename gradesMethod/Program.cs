/* Write a method that receives a grade between 2.00 and 6.00 and
 * prints the corresponding grade in words"
 * 
 * 2.00 - 2.99 = "F. - Fail"
 * 3.00 - 3.49 = "D. - Poor"
 * 3.50 - 4.49 = "C. - Good"
 * 4.50 - 5.49 = "B. Very Good"
 * 5.50 - 6.00 = "A. Excellent"
 * 
 * solution by me, sstankov.
 */

using System;

class Program
{
    static void Main()
    {
        double grade = double.Parse(Console.ReadLine()); //grade via input
        PrintGrade(grade); //calling the method, printing the grade
    }

    //creating the method that will print the grade:
    static void PrintGrade(double grade)
    {
        if (grade >= 2 && grade <= 2.99)
        {
            Console.WriteLine("F. - Fail");
        }

        else if (grade >= 3 && grade <= 3.49)
        {
            Console.WriteLine("D. - Poor");
        }

        else if (grade >= 3.50 && grade <= 4.49)
        {
            Console.WriteLine("C. - Good");
        }

        else if (grade >= 4.50 && grade <= 5.49)
        {
            Console.WriteLine("B. - Very Good");
        }

        else if (grade >= 5.50 && grade <= 6.00)
        {
            Console.WriteLine("A. - Excellent");
        }

    }
}


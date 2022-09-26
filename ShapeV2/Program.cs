using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





static void Main()
{
    Console.WriteLine("Let's draw a shape! Select a shape by typing: 'triangle', 'square', 'rectangle'.");
    string shape = Console.ReadLine();

    if (shape == "triangle")
    {

        Console.WriteLine("    /|");
        Console.WriteLine("   / |");
        Console.WriteLine("  /  |");
        Console.WriteLine(" /___|");

        Console.WriteLine("You selected TRIANGLE");
    }
    else if (shape == "rectangle")
    {

        Console.WriteLine("    ____________ ");
        Console.WriteLine("   |            |");
        Console.WriteLine("   |            |");
        Console.WriteLine("   |____________|");

        Console.WriteLine("You selected RECTANGLE");
    }
    else if (shape == "square")
    {

        for (int i = 0; i <= 3; i++)
        {


            for (int x = 0; x <= 3; x++)

            {
                if (i == 0 || i == 3)
                {
                    Console.Write("_");
                }
                else if (x == 0 || x == 3)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("    _______");
        Console.WriteLine("   |       |");
        Console.WriteLine("   |       |");
        Console.WriteLine("   |_______|");

        Console.WriteLine("You selected SQUARE");
    }
    else
    {
        Console.WriteLine("Invalid selection. Please try again.");
    }
}
Main();
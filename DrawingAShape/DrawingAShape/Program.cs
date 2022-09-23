using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace DrawingAShape
{ class Program
    {
        static void Main(string[] args)
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
    }
}

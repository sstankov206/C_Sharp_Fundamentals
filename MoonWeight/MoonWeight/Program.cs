//The gravitational field of the Moon is approximately 17% that of the Earth.
//Write a program, which will calculate a person's weight on the Moon,
//using their weight on Earth.

//Solution by me, sstankov

using System;

namespace MoonWeight
{
    class Program
{
    static void Main()
    {
            int earthWeight;
            //will use this variable to store the value of the person's weight
            //on Earth

            int weightOnMoon;
            //will use this variable to store the value of the person's weight
            //on the Moon

            Console.WriteLine("Please enter your weight");
            //prompt to have user input their weight (on Earth)

            earthWeight = Convert.ToInt32(Console.ReadLine());
            //input from user will be assigned as value to 'earthWeight' &
            //convert it to an integer. This will be their weight on Earth.

            //17% can be represented as 0.17
            //Below is a calucation using their weight on Earth to get their
            //weight on the Moon
            weightOnMoon = Convert.ToInt32(earthWeight * 0.17);

            Console.WriteLine("Your weight on the Moon would be {0}", weightOnMoon);
        }
}
}

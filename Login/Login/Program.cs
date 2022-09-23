/*You will be given a string representing a username. The password will be that
username reversed. Until you receive the correct password print on the console
"Incorrect password. Try again.". When you receive the correct password print
"User {username} logged in.". However on the fourth try if the password is still
no correct, print "User {username} blocked!" and end the program.

Solution by me, sstankov. */

using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your username:");

            string username = Console.ReadLine();

            string password = "";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }


            string input = Console.ReadLine();
            int attemptsCounter = 1;

            while (input != password)
            {
                if (attemptsCounter == 4)

                {
                    Console.WriteLine($"Username {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
                attemptsCounter++;

              
            }

            if (input == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }



        }
    }
}

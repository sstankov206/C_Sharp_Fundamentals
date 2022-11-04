/* Write a program that keeps track of guests, that are going to a house party. 
 * On the first line of input, you are going to receive the number of commands
 * you are going to receive. On the next lines you are going to receive one of 
 * the following messages:
 * - "{name} is going!"
 * - "{name} is not going!"
 * If you receive the first message, you have to add the person if he/she is not 
 * in the list and if he/she is in the list print on the console:
 * "{name} is already in the list!". If you receive the second message, you have 
 * to remove the person if he/she is in the list and if not print: 
 * "{name} is not in the list!". At the end print all the guests.
 * 
 * Examples:
 * 
 * INPUT:       4
 *              Allie is going!
 *              George is going!
 *              John is going!
 *              George is not going!
 *              
 * OUTPUT:      John is not on the list!
 *              Allie
 *              
 *  solution by me, sstankov.
 */

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //setting up a list that will hold the names:
        List<string> guests = new List<string>();

        //setting up the # of commands to receive, via input:
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            //array 'command' will keep track of "going" and "not going":
            //if elements in the array are 3 = "going". If elements are 4 = "Not going"
            string[] command = Console.ReadLine().Split();
            string name = command[0];

            if (command.Length == 3) //if "going"
            {

                if (guests.Contains(name)) //if name is already on the list
                {
                    //print the following message:
                    Console.WriteLine($"{name} is already on the list!");
                }
                else //if "going" but not on the list:
                {
                    guests.Add(name); //add the name to "going" list
                }
            }
            else //"not going"
            {
                if (guests.Contains(name)) //if name is on the "not going" list:
                {
                    guests.Remove(name); //remove the name
                }
                else //not found on list
                {
                    Console.WriteLine($"{name} is not in the list!");
                }
            }
        }
        //output, separated list of names on new line:
        Console.WriteLine(String.Join(Environment.NewLine, guests));
    }
}

/* You will receive a list of wagons(integers) on the first line. Every 
 * integer represents the number of passengers that are currently in each of 
 * the wagons. On the next line, you will get the max capacity of each wagon 
 * (a single integer). Until you receive "end" you will be given two types of input:
 * 
 * • Add{passengers} –add a wagon to the end with the given number of passengers.
 * • {passengers} - find an existing wagon to fit every passenger, starting 
 * from the first wagon. At the end print the final state of the train 
 * (each of the wagons, separated by a space).
 * 
 * Example:
 * 
 * INPUT:    32 54 21 12 4 0 23
 *           75
 *           Add 10
 *           Add 0
 *           30
 *           10
 *           75
 *           end
 *           
 * OUTPUT:   72 53 21 12 4 75 23 10 0
 * 
 * solution by me, sstankov.
 */

using System;


class Program
{
    static void Main(string[] args)
    {
        //creating the list from input
        List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();

        //determine max capacity of wagon via input
        int maxCapacity = int.Parse(Console.ReadLine());

        //determine command via input:
        string command = Console.ReadLine();
        while (command != "end")
        {
            string[] elements = command.Split(); //Ex: ["Add", "10"]

            //if 'command' contains "Add", add the 2nd element to 'passengers'
            if (elements[0] == "Add")
            {
                int passengers = int.Parse(elements[1]);
                train.Add(passengers);
            }
            else
            {
                int passengers = int.Parse(elements[0]);

                for (int i = 0; i < train.Count; i++)
                {
                    //checking if wagon's capacity will fit passengers:
                    if (train[i] + passengers <= maxCapacity)
                    {
                        train[i] += passengers; //adding passengers to wagon
                        break;
                    }
                }


            }

            command = Console.ReadLine();
        }

        Console.WriteLine(String.Join(' ', train)); //output
    }
}

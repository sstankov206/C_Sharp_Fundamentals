/* Write a program, which reads a listof integersfrom the consoleand receives 
 * commands, which manipulatethe list. Your program may receive the following commands:
 * • Delete {element}–deleteall elements in the array, which are equal to the given element.
 * • Insert {element} {position} –insert an element and the given position.
 * You should stop the program when you receive the command "end". 
 * Print the numbers in the array separated by a single white space.
 * 
 * Examples: 
 * 
 * INPUT:         1 2 3 4 5 5 5 6
 *                Delete 5
 *                Insert 10 1
 *                Delete 5
 *                end
 *                
 * OUTPUT:        1 10 2 3 4 6
 * 
 * solution by me, sstankov.
 */

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        //creating the list, from input:
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

        string command = Console.ReadLine();

        while (command != "end") //while the command DOESN'T = "end" :
        {
            string[] elements = command.Split();

            if (elements[0] == "Delete")
            {
                int elementToDelete = int.Parse(elements[1]);

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == elementToDelete) //remove all matching elements if command = "Delete"
                    {

                        list.RemoveAt(i);
                        i--;
                    }
                }
            }
            else if (elements[0] == "Insert") //insert corresponding element if command = "Insert"
            {
                int elementToInsert = int.Parse(elements[1]);
                int index = int.Parse(elements[2]);

                list.Insert(index, elementToInsert);
            }

            command = Console.ReadLine();
        }
        Console.WriteLine(String.Join(' ', list));

    }

}



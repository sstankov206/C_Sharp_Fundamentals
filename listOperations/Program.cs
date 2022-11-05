/*You will be given a list of integer numbers on the first line of input. You will
 * be receiving operations you have to apply on the list until you receive the 
 * "End" command. The possible commands are:
 * 
 * • Add {number} –add number at the end.
 * • Insert {number} {index} –insert number at given index.
 * • Remove {index} –remove at index.
 * • Shift left {count} –first number becomes last ‘count’ times.
 * • Shift right {count} –last number becomes first ‘count’ times.
 * Note: there is a possibility that the given index is outside of the bounds 
 * of the array. In that case print "Invalid index".
 * 
 * Examples:
 * 
 * INPUT:       1 23 29 18 43 21 20
 *              Add 5
 *              Remove 5
 *              Shift left 3
 *              Shift left 1
 *              End
 *              
 * OUTPUT:      43 20 5 23 29 18
 * 
 * solution by me, sstankov.
 */

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        //list of integers, created via input:
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

        //receiving operatios via input:
        string input = Console.ReadLine();

        //while the input operation ISN'T = "End":
        while (input != "End")
        {
            //array that will hold the different commands
            string[] commands = input.Split();

            string operation = commands[0]; //Ex: "Add", "Insert", "Remove", "Shift"

            switch (operation)
            {
                case "Add":
                    int number = int.Parse(commands[1]);
                    list.Add(number);
                    break;
                case "Insert":
                    int numToInsert = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]); //Ex: Insert {number} {index}

                    if (index > 0 && index < list.Count) //checking for valid index
                    {
                        list.Insert(index, numToInsert);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Index");
                    }
                    break;
                case "Remove":
                    int indexToRemove = int.Parse(commands[1]);

                    if (indexToRemove > 0 && indexToRemove < list.Count) //checking for valid index
                    {
                        list.RemoveAt(indexToRemove);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Index");
                    }

                    break;
                case "Shift":
                    //determing the 'count' via input:
                    int count = int.Parse(commands[2]);
                    if (commands[1] == "left")  //Ex: Shift left {count}
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int firstNum = list[0];
                            list.Add(firstNum);  //1st integer becomes last
                            list.RemoveAt(0);
                        }

                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int lastNum = list[list.Count - 1]; //last integer
                            list.Insert(0, lastNum); //last integer becomes 1st
                            list.RemoveAt(list.Count - 1);
                        }

                    }
                    break;
            }

            input = Console.ReadLine();
        }

        Console.WriteLine(String.Join(' ', list)); //output
    }
}



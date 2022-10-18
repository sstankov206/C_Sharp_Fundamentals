using System;


    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //will set number 'n' (lenght of array) via user/console input

            int[] arr = new int[n]; //creates array with 'n' as its length

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            Console.WriteLine(arr[i]);
            break;
         
            }

        string[] days = { " Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        int day = int.Parse(Console.ReadLine());

        if (day >= 1 && day <= 7)
        {
            Console.WriteLine(days[day - 1]);
        //outputs day as determined via console/input. 'day -1' as index ranges 0-6
        }
        else
            Console.WriteLine("Invalid day!");
        }

    }



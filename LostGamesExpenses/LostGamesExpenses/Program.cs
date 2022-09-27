/* As a competitive player of the MOBA video game genre, Peter has the bad habit
of trashing gaming equipment when he loses a game. His gaming setup consists of
headset, mouse, keyboard, and display. You will receive Peter's lost games count.

Every second lost game, Peter trashes his headset.
Every third lost game, Peter trashes his mouse.
When Peter trashes both his mouse and headset in the same lost game, he also
trashes his keyboard.

Every second time, when he trashes his keyboard he also trashes his display.


solution by me, sstankov.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int lostGamesCount = int.Parse(Console.ReadLine());

        //setting up prices for gaming gear items, via user input:
        double headsetPrice = double.Parse(Console.ReadLine());
        double mousePrice = double.Parse(Console.ReadLine());
        double keyboardPrice = double.Parse(Console.ReadLine());
        double displayPrice = double.Parse(Console.ReadLine());


        // if lostGameCount % 2 == 0 -> headset
        // if lostGamesCount % 3 == -> mouse
        // if lostGamesCount % 6 == 0 -> keyboard
        // if lostGamesCount % 12 == 0 -> display

        double rageExpenses = 0;

        for (int i = 1; i <= lostGamesCount; i++)
        {
            if (i % 2 == 0)
            {
                rageExpenses += headsetPrice;
            }

            if (i % 3 == 0)
            {
                rageExpenses += mousePrice;
            }

            if (i % 6 == 0)
            {
                rageExpenses += keyboardPrice;
            }

            if (i % 12 == 0)
            {
                rageExpenses += displayPrice;
            }

        }
        //output of cost to replace gaming gear

        Console.WriteLine($"Rage Expenses: ${rageExpenses:d2}.");


    }
}
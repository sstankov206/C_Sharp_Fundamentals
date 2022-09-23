/* Your task is to calculate the total price of a purchase from a vending machine.
  You have to sum them in order to have the total money inserted. There is a problem
  though. Your vending machine only works with 0.1, 0.2, 0.5, 1, and 2 coins.
  If someone tries to insert some other coins you have to display
  "Cannot accept {money}" and NOT add it to the total money. On the next few lines
  you receive "End" you will be given products to purchase. Your machine has however
  only "Nuts", "Water", "Crisps", "Soda, "Coke". The prices are: 2.0, 0.7, 1.5, 0.8, 1.0
  respectively. If the person tries to purchase a non existing product print "Invaid product".
Be carefu that the person may try to purchase a product they don't have the money for.
In that case print "Sorry, not enough money". If the person purchases a product
successfully print "Purchased {product name}". After the "End" command print the money that
are left formatted to the second deciman point in the format "Change: {money left}".

solution by me, sstankov */

using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculating total money being used:

            string command = Console.ReadLine();

            double totalSum = 0;

            while (command != "Start")
            {
                double currentAmount = double.Parse(command);

                if (currentAmount != 0.1 && currentAmount != 0.20 && currentAmount != 0.5
                    && currentAmount != 1 && currentAmount != 2)
                {
                    Console.WriteLine($"Cannot accept {currentAmount},");
                }
                else
                {
                    totalSum += currentAmount;
                }


                totalSum += currentAmount;
                command = Console.ReadLine();
            }

            // Buying products:

            string input = Console.ReadLine();

            while (input != "End")
            {
                double currentPrice = 0;
                switch (input)
                {
                    case "Nuts":
                        currentPrice = 2.0;
                        break;
                    case "Water":
                        currentPrice = 0.7;
                        break;
                    default:
                        break;

                }
            }
        }
    }
}












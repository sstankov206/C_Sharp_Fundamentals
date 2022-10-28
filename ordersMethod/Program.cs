/* Write a method that calculates the total price of an order and prints it on 
 * the console. The method should receive one of the following products: 
 * coffee, coke, water, snacks; and a quantity of the product. The prices for a 
 * single piece of each product are:
 * 
 * • coffee – 1.50
 * • water – 1.00
 * • coke – 1.40
 * • snacks – 2.00
 * 
 * Print the result formatted to the second decimal place
 * 
 * Example:
 * 
 * INPUT: water
 *          5
 * OUTPUT:  5.00
 * 
 * solution by me, sstankov.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select Product: coffee, water, coke, snacks");
        string product = Console.ReadLine(); //selecting product via input
        double price = 0; //variable that stores the price of the selected product
        Console.WriteLine("How many would you like?");
        int quantity = int.Parse(Console.ReadLine()); //selecting the quantity

        //switch statement for the products:
        switch (product)
        {
            case "coffee":
                price = 1.50;
                break;
            case "water":
                price = 1.00;
                break;
            case "coke":
                price = 1.40;
                break;
            case "snacks":
                price = 2.00;
                break;
        }

        double total = (double)(quantity * price); //variable that will calculate the total


        OrdersResult(total); //invokes the method below, prints the total of the order.
    }

    //creating the method that prints the result of the order:
    private static void OrdersResult(double total)
    {
      Console.WriteLine($"Your Total is: {total:f2}"); //prints result to the 2nd decimal place
    }
}

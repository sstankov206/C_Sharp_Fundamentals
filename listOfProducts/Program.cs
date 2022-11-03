/*Read a number n and n lines of products. Print a numbered list of all 
 * the products ordered by name.
 * 
 * Examples:
 * 
 * INPUT:       4
 *          Potatoes
 *          Tomatoes
 *          Onions
 *          Apples
 *          
 * OUTPUT:     1. Apples
 *             2. Onions
 *             3. Potatoes
 *             4. Tomatoes
 *             
 * solution by me, sstankov.           
 */



using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //determine 'n' lines via input:
        int n = int.Parse(Console.ReadLine());

        //iterating through the list, adding products via input:
        List<string> products = new List<string>();
        for (int i = 0; i < n; i++)
        {
            string currentProduct = Console.ReadLine(); products.Add(currentProduct);
        }
        products.Sort(); //sorting the list
        for (int i = 0; i < products.Count; i++)
            Console.WriteLine($"{i + 1}.{products[i]}"); //output
    }
}


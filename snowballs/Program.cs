/* Tony and Andi love playing in the snow and having snowball fights, but they
 * always argue who makes the best snowballs. They have decided to involve you
 * by making you write a program, which calculates snowball data, and outputs
 * the best snowball value.
 * 
 * You will receive 'N' - an integer, the number of snowballs being made by Tony
 * and by Andi. For each snowball you will receive 3 input lines:
 *  - On the 1st line, you will get the snowballSnow - an integer
 *  - On the 2nd line, you will get the snowballTime - an integer
 *  - On the 3rd line, you will get the snowballQuality - an integer
 *  
 *  For each snowball, you must calculate its snowballValue by the following
 *  formula:
 *           (snowballSnow / snowballTime) ^ snowballQuality
 *           
 *  At the end you must print the highest calculated snowballValue.
 *  
 *  INPUT:
 *  - On the 1st line you will receive 'N' - the number of snowballs
 *  - On the next N * 3 input lines you will be receiving data about snowballs
 *  
 *  OUTPUT:
 *  - As output you must print the highest calculated snowballValue, by the
 *  formula, specified above.
 *  - The output format is:
 *      {snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})
 *      
 *  CONSTRAINTS:
 *  - The number of snowballs (N) will be an integer in range [0, 100]
 *  - The snowballsSnow is an integer in range [0, 1000]
 *  - The snowballsTime is an integer in range [1, 500]
 *  - The snowballQuality is an integer in range [0, 100]
 *
 * solution by me, sstankov
 */

using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        byte numOfSnowballs = byte.Parse(Console.ReadLine());
        //determing number of snowballs via input

        BigInteger highestValue = int.MinValue; ;
        //will be used to store the highest calculated 'snowballValue'

        short highestSnow = 0;
        short highestTime = 0;
        short highestQuality = 0;
        //these will be used to store the highest value for each of the respective
        //variables

        for (int i = 0; i < numOfSnowballs; i++)
        {
            short snowballSnow = short.Parse(Console.ReadLine());
            short snowballTime = short.Parse(Console.ReadLine());
            byte snowballQuality = byte.Parse(Console.ReadLine());
            //input data about snowballs

            BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), (snowballQuality);

            if (snowballValue > highestValue)
            {
                highestValue = snowballValue;
                highestSnow = snowballSnow;
                highestTime = snowballTime;
                highestQuality = snowballQuality;
            }
        }

        Console.WriteLine($"{highestSnow} : {highestTime} = {highestValue} ({highestQuality})");
        //output
    }
}
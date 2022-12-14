/* You are given a list of words
 * Randomize their order and print each word on a separate line
 * 
 * Examples:
 * 
 * INPUT:       PHP Java C#
 * OUTPUT:      Java
 *              PHP
 *              C#
 *              
 * solution by me, sstankov.
 */

using System;
class Program
{
    static void Main()
    {
        //'randomizer' will take in string via input and randomize it:
        StringRandomizer randomizer = new StringRandomizer();
        randomizer.Words = Console.ReadLine().Split();
        randomizer.Randomise();
        randomizer.PrintWords();
    }
}

public class StringRandomizer
{
    public string[] Words; //array that will store the string of words

    public void Randomise()
    {
        Random rand = new Random();
        for (int i = 0; i < this.Words.Length; i++)
        {
            int randomPosition = rand.Next(0, this.Words.Length);
            string temp = this.Words[i];
            this.Words[i] = this.Words[randomPosition]; //swapping places
            this.Words[randomPosition] = temp;
        }
    }

    public void PrintWords()
    {
        Console.WriteLine(String.Join(Environment.NewLine, this.Words)); //output
    }
}


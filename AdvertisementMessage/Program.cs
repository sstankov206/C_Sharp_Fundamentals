/* Write a program that generates random fake advertisement messageto advertise 
 * a product. The messages must consist of 4 parts: phrase + event + author + city.
 * Use the following predefined parts:
 * 
 * • Phrases – {"Excellent product.", "Such a great product.", "I always use that product.",
 * "Best product of its category.", "Exceptional product.", "I can’t live without this product."}
 * 
 * • Events – {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
 * "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"}
 * 
 * • Authors – {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"}
 * 
 * • Cities – {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"}
 * 
 * The format of the output message is the following:
 * {phrase} {event} {author} –{city}.
 * 
 * You will receive the number of messagesto be generated. 
 * Print each random message at a separate line.
 * 
 * Examples:
 * 
 * INPUT:  3
 * 
 * OUTPUT:  Such a great product. Now I feel good. Elena - Ruse
 * Excellent product. Makes miracles. I am happy of the results! Katya - Varna
 * Best of its category. That makes miracles. Eva - Sofia
 * 
 * Solution by me, sstankov.
 */

using System;

class Program
{
    static void Main()
    {
        //determine how many phrases to generate, via input:
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(AdvertisementMessage.GenerateMessage());
        }
    }
}

//class for the Advertisement Messages:
public class AdvertisementMessage
{
    //creating array of strings that holds the phrases:
    public static string[] Phrases = new string[] {"Excellent product.",
        "Such a great product.",
        "I always use that product.",
        "Best product of its category.",
        "Exceptional product.",
        "I can’t live without this product."};

    //creating array of strings that holds the events:
    public static string[] Events = new string[] { "Now I feel good.",
        "I have succeeded with this product.",
        "Makes miracles. I am happy of the results!",
        "I cannot believe but now I feel awesome.",
        "Try it yourself, I am very satisfied.",
        "I feel great!"};

    //creating array of strings that holds the authors:
    public static string[] Authors = new string[] {"Diana", "Petya", "Stella", "Elena",
        "Katya", "Iva", "Annie", "Eva"};

    //creating array of strings that holds the cities:
    public static string[] Cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

    //method that generates the output message:
    public static string GenerateMessage()
    {
        Random rand = new Random();
        string currentPhrase = Phrases[rand.Next(0, Phrases.Length)];
        string currentEvent = Events[rand.Next(0, Events.Length)];
        string currentAuthor = Authors[rand.Next(0, Authors.Length)];
        string currentCity = Cities[rand.Next(0, Cities.Length)];

        return $"{currentPhrase} {currentEvent} {currentAuthor} – {currentCity}";
    }
}



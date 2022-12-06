/*Read 2 * N lines of pairs - word and synonym
 * Each word can have multiple synonyms
 * 
 * Examples:
 * 
 * INPUT:       3
 *             cute
 *             adorable
 *             cute
 *             charming
 *             smart
 *             clever
 *          
 * OUTPUT:      cute - adorable, charming
 *              smart - clever
 *              
 * Must use a dictionary for the solution.             
 *              
 * solution by me, sstankov
 */

using System;

class Program
{
    static void Main()
    {
        //determine number of line (N) via input:
        int n = int.Parse(Console.ReadLine());

        //create dictionary of strings:
        Dictionary<string, List<string>> wordSynonyms = new Dictionary<string, List<string>>();

        //for each iteration until length of N:
        for (int i = 0; i < n; i++)
        {
            //read a word & its synonym, via input:
            string word = Console.ReadLine();
            string synonym = Console.ReadLine();

            //contains word = yes? -> add synonym to dictionary
            if (wordSynonyms.ContainsKey(word))
            {
                wordSynonyms[word].Add(synonym);
            }
            //contains word = no? -> add word to dictionary
            else
            {
                wordSynonyms.Add(word, new List<string>());
                wordSynonyms[word].Add(synonym);//adds synonym to the new empty list
            }
        }

        //ouput:
        foreach (var pair in wordSynonyms)
        {
            Console.WriteLine(pair.Key + " - " + string.Join(", ", pair.
                ));
        }
    }
}


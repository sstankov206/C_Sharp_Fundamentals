/*Create a class Article with the following properties:
 * • Title – a string
 * • Content – a string
 * • Author – a string 
 *
 *The class should have a constructor and the following methods:
 *• Edit (new content) – change the old content with the new one
 *• ChangeAuthor (new author) –change the author
 *• Rename (new title) – change the title of the article
 *• Override the ToStringmethod – print the article in the following format: 
 *"{title} -{content}: {autor}" 
 *
 *Write a program that reads an article in the following format "{title}, {content}, {author}". 
 *On the next line, you will receive a number n, representing the number of commands, 
 *which will follow after it. On the next n lines, you will be receiving the following commands:
 *"Edit: {new content}"; "ChangeAuthor: {new author}"; "Rename: {new title}".At the end, 
 *print the final state of the article.
 *
 *Examples:
 *
 *INPUT:        some title, some content, some author
 *              3
 *              Edit: better content
 *              ChangeAuthor: better author
 *              Rename: better title
 *              
 *OUTPUT:       better title - better content: better author
 *
 *solution by me, sstankov.
 */

using System;
class Program
{
    static void Main()
    {
        //creating array that will hold the input:
        var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        Article article = new Article(input[0], input[1], input[2]);

        //reading 'n' lines via console input:
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var command = Console.ReadLine().Split(": ",
                StringSplitOptions.RemoveEmptyEntries).
                ToArray();

            switch (command[0])
            {
                case "Edit":
                    article.Edit(command[1]);
                    break;
                case "ChangeAuthor":
                    article.ChangeAuthor(command[1]);
                    break;
                case "Rename":
                    article.ChangeAuthor(command[1]);
                    break;
            }
        }

        Console.WriteLine(article.ToString); //output message
    }
}

//creating the 'Article' class:
public class Article
{
    //with the following properties;
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    //constructor for the class:
    public Article(string title, string content, string author)
    {
        this.Title = title;
        this.Content = content;
        this.Author = author;
    }

    //creating the 'Edit' method which will edit the content:
    public void Edit(string content)
    {
        this.Content = content;
    }

    //creating the method that changes the author:
    public void ChangeAuthor(string author)
    {
        this.Author = author;
    }

    //creating the method that changes the title:
    public void Rename(string title)
    {
        this.Title = title;
    }

    //creating override of .ToString() :
    public override string ToString()
    {
        return $"{Title} - {Content} : {Author}";
    }
}

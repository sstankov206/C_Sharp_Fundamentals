/* You will receive an input until you receive "END". Find what data type is the input. 
 Possible data types are:

· Integer

· Floating point

· Characters

· Boolean

· Strings

 Print the result in the following format: "{input} is {data type} type"

 solution by me, sstankov.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var datatype = string.Empty;

        while (!input.Equals("END",StringComparison.OrdinalIgnoreCase))
        {
            if (int.TryParse(input, out int num))
            {
                datatype = "integer";
                Console.WriteLine($"{input} is {datatype} type");
            }
            else if (double.TryParse(input, out double floatNum))
            {
                datatype = "floating point";
                Console.WriteLine($"{input} is {datatype} type");
            }

            else if (bool.TryParse(input, out bool boolResult))
            {
                datatype = "boolean";
                Console.WriteLine($"{input} is {datatype} type");
            }

            else
            {
                datatype = "character";
                Console.WriteLine($"{input} is {datatype} type");
            }
            
        }
    } 
}


     /* var input = Console.ReadLine();
        //will use this input variable to determine its data type

        var datatype = string.Empty;
        //will use this variable to store the data type

     if(input.Equals(typeof(int)))
        {
            datatype = "integer";
            Console.WriteLine($"{input} is {datatype} type");
            //checks if the input was integer, sets the data type equal to 'integer'
        }
        else if (input.Equals(typeof(float)))
        {
            datatype = "floating point";
            Console.WriteLine($"{input} is {datatype} type");
        }

        else if (input.Equals(typeof(char)))
        {
            datatype = "character";
            Console.WriteLine($"{input} is {datatype} type");
        }

        else if (input.Equals(typeof(bool)))
        {
            datatype = "boolean";
            Console.WriteLine($"{input} is {datatype} type");
        }

        else if (input.Equals(typeof(string)))
        {
            datatype = "string";
            Console.WriteLine($"{input} is {datatype} type");
        }
        else if (input == "END")
            return;

        else
        {
            Console.WriteLine("Invalid data type");
        }

    }
}
*/
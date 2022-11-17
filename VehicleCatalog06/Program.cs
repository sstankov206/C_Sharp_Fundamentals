/* You have to create a vehicle catalogue. You will store only two types of 
 * vehicles – a car and a truck. Until you receive the “End” command you will be 
 * receiving lines of input in the following format:
 * {typeOfVehicle} {model} {color} {horsepower}
 * After the “End” command, you will start receiving models of vehicles. Print
 * the data for every received vehicle in the following format:
 * Type: {typeOfVehicle}
 * Model: {modelOfVehicle}
 * Color: {colorOfVehicle}
 * Horsepower: {horsepowerOfVehicle}
 * When you receive the command “Close the Catalogue”, print the average horse 
 * power for the cars and for the trucks in the following format:
 * {typeOfVehicles} have average horsepower of {averageHorsepower}.
 * The average horse power is calculated by dividing the sum of the horsepower of
 * all vehicles from the certain type by the total count of vehicles from the 
 * same type. Round the answer to the 2nd digit after the decimal separator.
 * 
 * Constraints:
 * •The type of vehicle will always be either a car or a truck.
 * •You will not receive the same model twice.
 * •The received horsepower will be an integer in the range [1...1000]
 * •You will receive at most 50 vehicles.
 * •The separator will always be a single whitespace
 * 
 * Examples:
 * 
 * INPUT:           truck Man red 200
 *                  truck Mercedes blue 300
 *                  car Ford green 120
 *                  car Ferrari red 550
 *                  car Lamborghini orange 570
 *                  End
 *                  Ferrari
 *                  Ford
 *                  Man
 *                  Close the Catalogue
 *                  
 * OUTPUT:          Type: Car
 *                  Model: Ferrari
 *                  Color: red
 *                  Horsepower: 550
 *                  Type: Car
 *                  Model: Ford
 *                  Color: green
 *                  Horsepower: 120
 *                  Type: Truck
 *                  Model: Man
 *                  Color: red
 *                  Horsepower: 200
 *                  Cars have average horsepower of: 413.33
 *                  Trucks have average horsepower of: 250.00
 *                  
 *solution by me, sstankov */

using System;
using System.Text;
using System.Linq;

class Program
{
    static void Main()
    {
        //storing created vehicles in a list:
        List<Vehicle> vehicles = new List<Vehicle>();

        //reading input:
        string command = Console.ReadLine();

        //while input ISN'T = "End", do this:
        while (command != "End")
        {
            //create array of strings by splitting the input by whitespace:
            string[] commandElements = command.Split().ToArray();

            //creating a new vehicle each turn of the cycle:
            Vehicle vehicle = new Vehicle(commandElements[0],
                commandElements[1],
                commandElements[2],
                double.Parse(commandElements[3]));
            //add newly created vehicle to the list "vehicles" :
            vehicles.Add(vehicle);

            command = Console.ReadLine();
        }

        //creating 2nd while loop to check for input  "Close the Catalogue", which will terminate user input and print the output :
        string model = Console.ReadLine();
        while (model != "Close the Catalogue")
        {
            Console.WriteLine(vehicles.FirstOrDefault(x => x.Model == model).ToString(););


            model = Console.ReadLine();
        }

        //find all cars in the list 'vehicles' :
        var cars = vehicles.FindAll(x => x.Type == "car");
        var carHorsePower = cars.Sum(c => c.HorsePower);
        //calulcating the avg hp for cars
        var carAveragePower = carHorsePower / cars.Count;

        var trucks = vehicles.FindAll(x => x.Type == "truck");
        var truckHorsePower = trucks.Sum(t => t.HorsePower);
        //calulcating the avg hp for trucks
        var truckAveragePower = truckHorsePower / trucks.Count;

        if (cars.Count == 0)
        {
            carAveragePower = 0;
        }
        if (trucks.Count == 0)
        {
            truckAveragePower = 0;
        }

        //output:
        Console.WriteLine($"Cars have average horsepower of: {carAveragePower:f2}");
        Console.WriteLine($"Trucks have average horsepower of: {truckAveragePower:f2}");
    }
}

//creating class that contains properties for each vehicle:

public class Vehicle
{
    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public double HorsePower { get; set; }

    //constructor
    public Vehicle(string type, string model, string color, double horsepower)
    {
        this.Type = type;
        this.Model = model;
        this.Color = color;
        this.HorsePower = horsepower;
    }

    //override ToString() method :
    public override string ToString()
    {
        //what the return needs to look like:

        //Type: { typeOfVehicle}
        //Model: { modelOfVehicle}
        //Color: { colorOfVehicle}
        //Horsepower: { horsepowerOfVehicle}

        StringBuilder stringBuilder = new StringBuilder();

        //check if 'car' or 'truck', append the input in capitalized form:
        if (this.Type == "car")
        {
            stringBuilder.AppendLine($"Type: Car");
        }
        else
        {
            stringBuilder.AppendLine($"Type: Truck");
        }

        stringBuilder.AppendLine($"Type: {this.Type}");
        stringBuilder.AppendLine($"Model: {this.Model}");
        stringBuilder.AppendLine($"Color: {this.Color}");
        stringBuilder.AppendLine($"Horsepower: {this.HorsePower}");


        //print in requested above format, with the empty line at the end removed:
        return stringBuilder.ToString().TrimEnd();
    }
}





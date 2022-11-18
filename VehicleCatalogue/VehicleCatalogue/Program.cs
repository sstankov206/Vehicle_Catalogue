using System;
using VehicleCatalogue;


class Program
{
    static void Main()
    {
        /* TO DO:
         * create 3 classes - Truck, Car, Catalog with properties
         * Read input until "end" command with proper format
         * Print all of the vehicles ordered alphabetically by brand in proper format
         */

        //reading input:
        string command = Console.ReadLine();

        //new list 'catalog' of the "Catalog" class, which will store cars and trucks:
        Catalog catalog = new Catalog();

        //while the input ISN'T = "end" :
        while (!command.Equals("end"))
        {
            string[] input = command.Split("/"); //separate input by '/'

            //check for 'car' or 'truck', then create new instances of each:
            if (input[0] == "Car")
            {
                Car car = new Car {
                    Brand = input[1],
                    Model = input[2],
                    HorsePower = int.Parse(input[3])};
                catalog.Cars.Add(car);
            }
            else if (input[0] == "Truck")
            {
                Truck truck = new Truck(input[1], input[2], int.Parse(input[3]))
                { 
                 
                };
                catalog.Trucks.Add(truck);
            }
            command = Console.ReadLine();
        }
        //output, sorted alphabetically and printed in the requested format:
        Console.WriteLine(catalog.ToString());
    }
}


using System;
namespace VehicleCatalogue
{ //Car class:
    public class Car
    {
        //properties:

        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }

        //constructor

        public Car(string brand, string model, int horsepower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsepower;
        }

        public Car()
        {

        }

        //creating override of .ToString(), to create proper formatting:
        public override string ToString()
        {
            return
                $"{Brand}:{Model} - {HorsePower}hp";
                
                
        }
    }
}


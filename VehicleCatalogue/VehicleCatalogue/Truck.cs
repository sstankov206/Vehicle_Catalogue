using System;
namespace VehicleCatalogue
{ //Truck class:
    public class Truck
    {
        //properties:
        public string Brand { get; set; }
        private string Model { get; set; }
        private int Weight { get; set; }

        //constructor:
        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;

        }

        public Truck()
        {

        }

        public override string ToString()
        {
            return 
                $"{Brand}: {Model} - {Weight}kg";
        }
    }
}


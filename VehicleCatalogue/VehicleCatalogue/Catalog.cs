using System;
using System.Linq;
using System.Text;

namespace VehicleCatalogue
{//Catalog class:

    public class Catalog
    {
        //properties:

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }


        //Constructor:

        public Catalog(List<Car> cars, List<Truck> trucks)
        {
            this.Cars = cars;
            this.Trucks = trucks;
        }
        public Catalog()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }

        public override string ToString()
        {
            StringBuilder cars = new StringBuilder();
            Cars
                .OrderBy(c => c.Brand)
                .ToList()
                .ForEach(c => cars.Append(c.ToString()).Append("\n"));
            StringBuilder trucks = new StringBuilder();
            Trucks
                .OrderBy(t => t.Brand)
                .ToList()
                .ForEach(t => trucks.Append(t.ToString()).Append("\n"));
            return $"Cars: \n{cars}Trucks:\n{trucks}";
        }
    }
}


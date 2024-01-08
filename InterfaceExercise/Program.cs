using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            var truck = new Truck()
            {
                Year = 2020,
                Make = "Ford ",
                Model = "F150",
                CabSize = "Extended",
                BedSize = "Long",
                Condition = "Like New Condition"
            };

            var car = new Car()
            {
                Year = 2009,
                Make = "Toyota ",
                Model = "Camry",
                Condition = "Good",
                SedanOrCoupe = "Sedan",
                HasTrunk = true,
                Name = "Richard's Preowned Cars",
                Description = "Used Car Lot"
            };

            var suv = new SUV()
            {
                Year = 2010,
                Make = "Subaru",
                Model = "Outback",
                Condition = "Excellent", 
                CargoSpaceCubicFeet = 15.2,
                NumberOfPassengers = 5

            };
            
            Console.WriteLine($"{car.Name} has a {car.Year + " " + car.Make + car.Model} in {car.Condition} condition for sale.");
            Console.WriteLine($"A {suv.Make + " " + suv.Model} with {suv.NumberOfPassengers} passengers was involved in an accident today. Everyone is okay.");
            Console.WriteLine($"A {truck.Year + " " + truck.Make + truck.Model} in {truck.Condition} is being traded in. It is an {truck.CabSize} cab with a {truck.BedSize} bed.");


        }
    }
}
;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car car1 = new Car () { HasTrunk = true, Make = "honda", Year = "2020", Model = "Accord" };

            Motorcycle yamaha = new Motorcycle () { HasSideCart = true, Make = "yamaha", Year = "2020", Model = "rx1" };
            Vehicle acura = new Car () { HasTrunk = true, Make = "honda", Year = "2021", Model = "mdx" };
            Vehicle suzuki = new Motorcycle () { HasSideCart = true, Make = "suzuki", Year = "2019", Model = "gtxr" };

            /*
         * Add the 4 vehicles to the list
         
         * Using a foreach loop iterate over each of the properties
         */
            vehicles.Add(car1);
            vehicles.Add(yamaha);
            vehicles.Add(acura);
            vehicles.Add(suzuki);
           // Console.WriteLine(vehicles.Count);
            foreach (var item in vehicles)
            {
                Console.WriteLine($"{item.Year},{item.Make},{item.Model}");
            }

            Console.WriteLine("---------");
            // Call each of the drive methods for one car and one motorcycle
            car1.DriveAbstract();
            yamaha.DriveAbstract();
            car1.DriveVirtual();
            yamaha.DriveVirtual();
            
            #endregion
            Console.ReadLine();
        }
    }
}

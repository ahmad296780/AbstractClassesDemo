using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "2000";
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Camry";

        public abstract void DriveAbstract();
        public void DriveVirtual()
        {
            Console.WriteLine("drive virtual");
        }
    }
   public class Car : Vehicle
    {
        public bool HasTrunk { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("driving car abstract");
        }
    }
    public class Motorcycle : Vehicle
    {
       public bool HasSideCart { get; set; }
       public  override void DriveAbstract()
        {
            Console.WriteLine("driving bike abstract");
        }
    }
}

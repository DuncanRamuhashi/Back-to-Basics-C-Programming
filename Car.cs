using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_to_Basics_C__Programming
{
    internal class Car : Vehicle
    {
        int _numberOfDoors;

        public Car(string brand, string model, int year, int numberOfDoors): base(brand, model, year)
        {
            _numberOfDoors = numberOfDoors;
        }

        public override void Start()
        {
            Console.WriteLine("Car is starting...");
        }
    }
}

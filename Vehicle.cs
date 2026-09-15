using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Back_to_Basics_C__Programming
{
    internal abstract class Vehicle
    {
        private string _brand;
        private string _model;
        private int _year;

        public Vehicle(string brand, string model, int year)
        {
            _brand = brand;
            _model = model;
            _year = year;
        }

        public void displayInfo()
        {
            Console.WriteLine($"Brand: {_brand}, Model: {_model}, Year: {_year}");
        }
        public abstract void Start();


    }
}

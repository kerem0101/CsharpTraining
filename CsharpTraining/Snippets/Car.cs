using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining.Snippets
{
    internal class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string brand, string model, string year ) 
        { 
            Brand = brand;
            Model = model;
            Year = year;
        }
        public override void Start() { Console.WriteLine("Car is starting"); }
        public override void Stop() { Console.WriteLine("Car is stopping"); }
    }
}

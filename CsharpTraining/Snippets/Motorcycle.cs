using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining.Snippets
{
    internal class Motorcycle : Vehicle
    {

        public Motorcycle(string brand, string model, string year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
        public override void Start() { Console.WriteLine("Motorcycle is starting"); }
        public override void Stop() { Console.WriteLine("Motorcycle is stopping"); }
    }
}

using ConsoleCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator.Classes
{
    class Car : Vehicle, ICar
    {
        public int NumberOfWheels { get; set; }

        public Car() : base() { }

        public Car(string color): base (color) { }

        public Car(string color, string year): base (color, year) { }

        public Car(string color, string year, int numberOfWheels): this(color, year)
        {
            NumberOfWheels = numberOfWheels;
        }

        public void Break()
        {
            Console.WriteLine("Breaks!!!"); ;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Wheels: {NumberOfWheels}";
        }
    }
}

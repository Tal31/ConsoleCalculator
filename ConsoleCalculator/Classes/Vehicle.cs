using ConsoleCalculator.Interfaces;
using System;

namespace ConsoleCalculator.Classes
{
    /// <summary>
    /// This is my great vehicle object that will raise me $1M
    /// </summary>
    class Vehicle : Program, IVehicle
    {
        #region Public members
        /// <summary>
        /// This would be the color of my vehicle and that's it
        /// </summary>
        public string Color
        {
            get
            {
                return GetFormattedColor();
            }

            private set
            {
                _color = SetUppercaseColor(value);
            }
        }

        public Car vehicleCar { get; set; }

        // public string Color { get; set; }
        #endregion

        public int Year { get; }

        #region Private members

        private string _color;
        private int _year;
        #endregion

        #region Constructors
        /// <summary>
        /// This constructor whil create a vehicle with default color
        /// </summary>
        public Vehicle() 
        {
            Color = "default";
            _year = 2000;
        }

        /// <summary>
        /// Another one
        /// </summary>
        /// <param name="color">The color you like for your vehicle</param>
        public Vehicle(string color) : this()
        {
            _color = SetUppercaseColor(color);
        }

        public Vehicle(string color, string year) : this(color)
        {
            _year = int.Parse(year);
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Method
        /// </summary>
        /// <param name="param">param 1</param>
        /// <returns>Something</returns>
        public string SomeFunction(string param)
        {
            Console.WriteLine("Hi");
            return "";
        }

        public void MoveForward()
        {
            //throw new NotImplementedException();
            Console.WriteLine("I'm moving forward");
        }

        #region Overrides
        public override string ToString()
        {
             return $"Year: {_year}, {GetFormattedColor()}";
        }
        #endregion
        #endregion

        #region Private methods
        private string GetFormattedColor()
        {
            return $"Color: {_color}";
        }

        private string SetUppercaseColor(string color)
        {
            return color.ToUpper();
        }
        #endregion
    }

}

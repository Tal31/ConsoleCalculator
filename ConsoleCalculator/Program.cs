using ConsoleCalculator.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //IfExample();

            //ForeachExample();

            //int sum = CalculateSumOfNumbersTill(100);
            //Console.WriteLine($"Sum is {sum}");
            //sum = WhileExample(sum);
            //sum = DoWhileExample(sum);

            List<Vehicle> vehicles = new List<Vehicle>();
            try
            {
                Car car1 = new Car("red", "2022", 4);
                car1.MoveForward();
                car1.Break();
                string color = car1.Color;
                vehicles.Add(car1);

                Vehicle vehicle2 = new Vehicle("blue", "2011");
                vehicle2.MoveForward();
                vehicles.Add(vehicle2);
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    Console.WriteLine("Year provided is not a number");
                }
                else if (ex is Exception)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //vehicles.Add(new Vehicle("blue"));
            //vehicles.Add(new Vehicle() { Color = "green" });
            //vehicles.Add(new Vehicle(color));

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }

            Console.ReadKey();
        }

        private static int DoWhileExample(int sum = 0)
        {
            int num = 10;
            do
            {
                sum += num;
                num++;
            } while (num < 10);
            Console.WriteLine(sum);
            return sum;
        }

        private static int WhileExample(int sum = 0)
        {
            int num = 10;
            while (num < 10)
            {
                sum += num;
                num++;
            }
            Console.WriteLine(sum);
            return sum;
        }

        private static void ForeachExample()
        {
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Grape");
            fruits.Add("Passionfruit");
            fruits.Add("Lemon");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }

        private static int CalculateSumOfNumbersTill(int tillNumber)
        {
            int sum = 0;
            for (int i = 0; i < tillNumber; i++)
            {
                sum = sum + i;
            }

            return sum;
        }

        private static void IfExample()
        {
            bool IsSunday = DateTime.Today.DayOfWeek == DayOfWeek.Sunday;
            if (IsSunday)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("Not sunday");
            }
        }
    }

}

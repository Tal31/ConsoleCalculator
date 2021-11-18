using SuperMarket.Classes;
using System;
using System.Collections.Generic;

namespace SuperMarket
{
    public class Program
    {
        public static void Main(string[] args)

        {
            List<FruitDep> fruit = new List<FruitDep>();

            {
                FruitDep Pear = new FruitDep(1, 100, "Pear");
                int ID = Pear.ID;
                double Weight = Pear.Weight;
                string Name = Pear.Name;
                fruit.Add(Pear);

               // FruitDep Apple = new FruitDep(2, 200, "Apple");

               // FruitDep Banana = new FruitDep(3, 300, "Banana");
                Console.WriteLine(List);
                Console.ReadLine();
        }
            }

                
               
    
    }           
}
        
    

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Classes
{
    class FruitDep : Program
    {
        public double Weight { get; set; }
        public double Expire_Date { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string V { get; }

        public FruitDep(int id, double weight)
        {
            ID = id;
        }

        public FruitDep(double weight)
        {
            Weight = weight;

        }

        public FruitDep(string name)
        {
            Name = name;
            //}

            //    public FruitDep(int id, int weight, string name) : this(id)
            //    public FruitDep(int id, int weight, string name) : this(weight)
            //    public FruitDep(int id, int weight, string name) : this(name)




        }

        public FruitDep(int id, double weight, string v) : this(id, weight)
        {
            V = v;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Id: {ID}"; 
        }

        //    private static string ToString(FruitDep);
        //    {
        //        return FruitDep.ToString();
        //    }
    }

}

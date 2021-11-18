using Items_Exrecise.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items_Exrecise
{
    public class SuperMarket
    {
        static void Main(string[] args)
        {
            var meatDepartment = new MeatDepartment1(2,12.22,300);

            meatDepartment.Weight = 2;


            var SweetDepartment = new SweetDepartment();

            var MilkDepartment = new MilkDepartment();


        }
    }
}

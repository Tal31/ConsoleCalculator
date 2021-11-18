using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items_Exrecise.Classes
{
    public class MeatDepartment: IDepartment
    {
        public double Weight { get; set; }
        public double Expire_Date { get; set; }
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public MeatDepartment(double weight); 
        {
            Weight = weight;
        }

        public int MyProperty
        {
            get { return Weight; }
            set { Weight = value; }
        }









    }
}

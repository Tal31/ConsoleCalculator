using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.InterFaces
{
    interface IDepartment
    {
        public double Weight { get; set; }

        public double Expire_Date { get; set; }

        public int ID { get; set; }
    }
}

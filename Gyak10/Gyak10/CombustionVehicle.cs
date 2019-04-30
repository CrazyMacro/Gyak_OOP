using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak10
{
    class CombustionVehicle : Vehicle
    {

        public CombustionVehicle(String type, int displacement, double consumption, int distance) : base(type, displacement, consumption, distance)
        {
        }

        public override string ToString()
        {
            return base.ToString() + "\n";
        }
    }
}

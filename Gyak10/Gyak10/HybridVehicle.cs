using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak10
{
    class HybridVehicle : Vehicle
    {
        double savingFactor;

        public HybridVehicle(String type, int displacement, double consumption, int distance, double savingFactor) : base(type, displacement, consumption, distance)
        {
            this.savingFactor = savingFactor;
        }

        public override string ToString()
        {
            return base.ToString() + savingFactor + "\n";
        }
    }
}

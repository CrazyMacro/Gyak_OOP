using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak10
{
    class Vehicle
    {
        String type;
        int displacement;
        double consumption;
        int distance;

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public int Displacement
        {
            get
            {
                return displacement;
            }

            set
            {
                displacement = value;
            }
        }

        public int Distance
        {
            get
            {
                return distance;
            }

            set
            {
                distance = value;
            }
        }

        public Vehicle(String type, int displacement, double consumption, int distance)
        {
            this.Type = type;
            this.Displacement = displacement;
            this.consumption = consumption;
            this.Distance = distance;
        }

        public override string ToString()
        {
            return type + ";" + displacement + ";" + consumption + ";" + distance;
        }
    }
}

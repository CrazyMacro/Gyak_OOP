using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julcsival_gyakorlas_zh2rendelo
{
    public class Beteg
    {
        private int sorszam, tajszam;

        public int Sorszam { get => sorszam; set => sorszam = value; }
        public int TajSzam { get => tajszam; set => tajszam = value; }


        public override String ToString()
        {
            return Sorszam.ToString() + "\t" + TajSzam.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RaktarNyilvantartas
{
    public class Aru
    {
        private string nev;
        private string azon;
        /// <summary>
        /// nettó ár
        /// </summary>
        private int ar;

        //public Aru()
        //{ }

        public Aru(string nev, string azon, int ar)
        {
            this.nev = nev;
            this.azon = azon;
            this.ar = ar;
        }

        public string Nev
        {
            get
            {
                return nev;
            }

            set
            {
                nev = value;
            }
        }

        public string Azon
        {
            get
            {
                return azon;
            }

            set
            {
                azon = value;
            }
        }

        public int Ar
        {
            get
            {
                return ar;
            }

            set
            {
                ar = value;
            }
        }

        
        public override String ToString()
        {
            return nev + "\t" + azon + "\t" + ar;
        }
    }
}
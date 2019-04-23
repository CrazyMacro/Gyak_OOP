using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RaktarNyilvantartas
{
    public class AruTetel
    {
        private Aru aru;
        private int db;
        private string kod;

        public Aru Aru
        {
            get
            {
                return aru;
            }

            set
            {
                aru = value;
            }
        }

        public int Db
        {
            get
            {
                return db;
            }

            set
            {
                db = value;
            }
        }

        public string Kod
        {
            get
            {
                return kod;
            }

            set
            {
                kod = value;
            }
        }


        public int TetelAr
        {
            get
            {
                return aru.Ar * db;
            }

        }


        public override String ToString()
        {
            return Aru.Nev + Aru.Azon + db + kod;
        }
    }

}
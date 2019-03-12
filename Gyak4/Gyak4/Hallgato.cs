using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak4
{
    class Hallgato
    {
        private String Neptun;
        private String Password;

        public Hallgato(String inputNeptun, String inputPassword)
        {
            Neptun = inputNeptun;
            Password = inputNeptun;
        }

        public string Neptun1
        {
            get
            {
                return Neptun;
            }

            set
            {
                Neptun = value;
            }
        }

        public string Password1
        {
            get
            {
                return Password;
            }

            set
            {
                Password = value;
            }
        }
    }
}

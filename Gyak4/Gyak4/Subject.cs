using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gyak4
{
    class Subject
    {
        private String neptun;
        private String name;
        private int credit;
        private List<Subject> requirements = new List<Subject>();

        public string Neptun
        {
            get
            {
                return neptun;
            }

            set
            {
                neptun = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Credit
        {
            get
            {
                return credit;
            }

            set
            {
                if (value >= 0 && value <= 6)
                {
                    credit = value;
                }
                else
                {
                    MessageBox.Show("Hibás kredit érték");
                }
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julcsival_gyakorlas_zh2rendelo
{
     public class IdopntosBeteg : Beteg
    {
        private String idopont;

        public string Idopont { get => idopont; set => idopont = value; }

        public override String ToString()
        {
            return Sorszam.ToString() + "\t" + TajSzam.ToString() + "\t" + Idopont;
        }
    }
}

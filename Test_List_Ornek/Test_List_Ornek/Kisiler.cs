﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_List_Ornek
{
    internal class Kisiler
    {
        string ad;
        string soyad;
        string meslek;

        public string ADI
        {
            get { return ad; } set { ad = value; }
        }
        public string SOYAD
        {
            get { return soyad; } set { soyad = value; }
        }
        public string Meslek
        {
            get { return meslek; }
            set { meslek = value; }
        }
    }
}

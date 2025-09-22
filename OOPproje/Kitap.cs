using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPproje
{
    public class Kitap
    {
        string kitapad;
        string yazar;
        int ıd;
        public int IDD
        {
            get { return ıd; }
            set { ıd = value; }
        }

        public string Kitapadd
        {
            get { return kitapad; }
            set { kitapad = value; }
        }
        public string Yazarr
        {
            get { return yazar; }
            set { yazar = value; }
        }
    }
}

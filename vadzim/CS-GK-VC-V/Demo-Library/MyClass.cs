using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Library
{
    public class MyClass
    {
        // felder, klein geschrieben
        private string str_Feld;
        private int int_Feld;

        // eigenschaften, groß

        // konstruktoren 

        // methoden, groß
        public void SetFelder(string arg1, int arg2)
        {
            str_Feld = arg1;
            int_Feld = arg2;
        }
        public string GetFelder()
        {
            return str_Feld + " " + int_Feld;
        }
        // destruktor
    }
}

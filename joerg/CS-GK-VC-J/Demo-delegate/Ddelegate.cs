using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_delegate
{
    class Ddelegate
    {
        #region Schritt1
        public static int Addiere(int a, int b)
        {
            int summe = a + b;
            Console.WriteLine($"Addiere {a} + {b}, summe: {summe}");
            return summe;
        }
        public static int Subtrahiere(int a, int b)
        {
            int differenz = a - b;
            Console.WriteLine($"Subtrahiere,{a} - {b} differenz: {differenz}");
            return differenz;
        }
        #endregion
        #region Schritt2
        public delegate int MeinDelegat(int a, int b);

        #endregion
        static void Main(string[] args)

        {
            #region Schritt3
            MeinDelegat meinDelegat = new MeinDelegat(Addiere);
            //int resultat = meinDelegat.Invoke(2, 3);
            //es funktioniert auch ohne Invoce()
            int resultat = meinDelegat(2, 3);
            Console.WriteLine($"resultat: {resultat}");

            //meinDelegat = meinDelegat + Subtrahiere;
            //kürzer:
            meinDelegat +=  Subtrahiere;
            resultat = meinDelegat(3, 4);
            Console.WriteLine($"resultat: {resultat}");

            #endregion
            Console.ReadKey();
        }
    }
}

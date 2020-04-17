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
            Console.WriteLine($"Subtrahiere {a} - {b}, differenz: {differenz}");
            return differenz;
        }
        #endregion

        #region Schritt2        
        public delegate int MeinDelegat(int da, int db);
        #endregion


        #region Callbacks1
        public static int FühreAus(Func<int, int, int> auszuführendeMethode, int zahl1, int zahl2)
        {
            int result = auszuführendeMethode(zahl1, zahl2);
            return result;
        }
        #endregion


        #region Lists & Delegates Step 1
        public static bool SucheStadtMitH(string stadt)
        {
            bool startetMitH = stadt.StartsWith("H");
            return startetMitH;
        }
        #endregion

        static void Main(string[] args)
        {
            #region Schritt3
            Console.WriteLine("\n ### COSTUM DELEGATE ###");
            MeinDelegat meinDelegat = new MeinDelegat(Addiere);
            //int resultat = meinDelegat.Invoke(2, 3);
            // es funktioniert auch ohne Invoke()
            int resultat = meinDelegat(2, 3);
            Console.WriteLine($"resultat: {resultat}");

            //meinDelegat = meinDelegat + Subtrahiere;
            // kürzer: 
            meinDelegat +=  Subtrahiere;
            resultat = meinDelegat(3, 4);
            Console.WriteLine($"resultat: {resultat}");
            #endregion


            #region Vordefinierte Delegaten
            Console.WriteLine("\n ### FUNC ###");
            // <arg1type, arg2type, returntype>
            Func<int, int, int> meinFuncDelegat = Addiere;
            meinFuncDelegat += Subtrahiere;
            Console.WriteLine($"meinFuncDelegat(5,6): {meinFuncDelegat(5,6)}");
            #endregion

            #region Use method with callback
            Console.WriteLine("\n ### CALLBACK ###");
            int ergebnis = FühreAus(Addiere, 4, 5);
            Console.WriteLine($"ergebnis: {ergebnis}");
            #endregion

            #region arrow
            // Arrow-Function / Pfeilfunktion / Lambda
            Console.WriteLine("\n ### ARROW ###");
            // int ergebnis2 = FühreAus((int a, int b) => { return a * b; }, 5, 6);
            int ergebnis2 = FühreAus((int a, int b) => a * b, 5, 6);
            Console.WriteLine($"ergebnis2: {ergebnis2}");
            #endregion

            #region Lists & Delegates Step2
            Console.WriteLine("\n ### Lists & Delegates ###");
            List<string> Städteliste = new List<string>() { "Karlsruhe", "Hamburg", "Hannover", "Stuttgart" };
            string gefundeneStadt = Städteliste.FindLast(SucheStadtMitH);
            Console.WriteLine($"gefundeneStadt: {gefundeneStadt}");

            Console.WriteLine("\n ### Lists & Arrowfunctions ###");
            // gefundeneStadt = Städteliste.FindLast(); //mitK
            Console.WriteLine($"gefundeneStadt: {gefundeneStadt}");
            #endregion


            Console.ReadKey();
        }
    }
}

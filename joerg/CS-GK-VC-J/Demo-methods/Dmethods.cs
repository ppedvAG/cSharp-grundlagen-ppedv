using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_methods
{
    class Dmethods
    {
        //Declaration von einer Methode:
        //wan eine Methode alleine, ohne eine Klasse aufzurufen
        //muss sie static sein
        public static bool SagWas()
        {
            Console.WriteLine("Was?");
            bool IchHabAllesGesagtreturn;
            IchHabAllesGesagtreturn = true;
            return IchHabAllesGesagtreturn;
        }

        public static bool SagWas(string was)
        {
            if (was == "Schnauze")
            {
                was = "Sie sind unerzogen! Schnauze darf man nicht sagen";
            }
            Console.WriteLine(was);
            bool IchHabAllesGesagtreturn;
            IchHabAllesGesagtreturn = false;
            return IchHabAllesGesagtreturn;
        }

        static void Main(string[] args)
        {
            // aufruf einer Methode, ohne den return abzufangen
            SagWas();

            // aufruf einer Methode, ohne den return abzufangen
            bool resultat = SagWas();
            Console.WriteLine($"Ergebnis der Methode: {resultat}");

            // aufruf einer Methode, ohne den return abzufangen
            resultat = SagWas("schnauze");
            Console.WriteLine($"Ergebnis der Methode: {resultat}");

            Console.ReadKey();
        }
    }
}

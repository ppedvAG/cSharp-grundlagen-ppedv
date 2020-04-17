using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMethods
{
    class DMethods
    {
        // Deklaration von einer Methode:
        // will man eine Methode alleine, ohne irgendwelche Klasse aufrufen,
        // muss sie static sein
        public static bool SagWas()
        {
            Console.WriteLine("Was?");
            bool ichHabAllesGesagt;
            ichHabAllesGesagt = true;
            return ichHabAllesGesagt;
        }

        public static bool SagWas(string was)
        {
            if (was == "Schnauze")
            {
                was = "Sie sind unerzogen! Schnauze darf man nicht sagen";
            }
            Console.WriteLine(was);
            bool ichHabAllesGesagt;
            ichHabAllesGesagt = false;
            return ichHabAllesGesagt;
        }

        static void Main(string[] args)
        {
            // aufrufen einer Methode, ohne den return abzufangen
            SagWas();

            // Aufrufen einer Methode und Abfangen von return
            bool resultat1 = SagWas();
            Console.WriteLine($"Ergebnis der Methode: {resultat1}");

            // Aufrufen einer Methode und Abfangen von return
            bool resultat2 = SagWas("Schnauze");
            Console.WriteLine($"Ergebnis der Methode: {resultat2}");

            Console.ReadKey();
        }
    }
}

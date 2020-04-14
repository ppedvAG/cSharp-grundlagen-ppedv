using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namensraum: Umgebung für Klassen. 
// Namen in einem Namensraum sollen eindeutig sein.
namespace M1HelloWorld
{
    // Klassen - Objektorientierung
    class M1HelloWorld
    {
        static void Main(string[] args)
        {
            // Es gibt Klassen, die vorprogrammiert sind
            // die verwenden wir als Werkzeuge
            Console.WriteLine("Hallo C#");

            string varZumKurzenAufbewahrenVonText;
            varZumKurzenAufbewahrenVonText = "Buchstabensalat";
            Console.WriteLine(varZumKurzenAufbewahrenVonText);

            // damit die Konsole nicht verschwindet
            Console.ReadKey();
        }
    }
}

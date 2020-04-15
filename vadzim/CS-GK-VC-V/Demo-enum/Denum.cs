using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_enum
{
    class Denum
    {
        enum Pizzagröße
        {
            Klein, Mittel, Groß, Family=4
        }
        static void Main(string[] args)
        {
            Pizzagröße pizzagröße = Pizzagröße.Mittel;

            Console.WriteLine($"- Ich hab eine {pizzagröße}-Pizza genommen.");

            Pizzagröße pizzagröße1 = (Pizzagröße)3;

            // Wenn Index 3 beim Enumerator nicht belegt ist, 
            // dann ist das Ergebnis beim Casten die Zahl selbst
            Console.WriteLine($"- Und ich hab eine {pizzagröße1}-Pizza genommen.");


            Pizzagröße pizzagröße2 = (Pizzagröße)0.3;
            Console.WriteLine($"- Und ich hab eine {pizzagröße2}-Pizza genommen.");
            // .3 wurde zu 0 gecastet

            Console.ReadKey();
        }
    }
}

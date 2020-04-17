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
            Klein, Mittel, Groß, Family
        }

        static void Main(string[] args)
        {
            Pizzagröße pizzagröße = Pizzagröße.Mittel;

            Console.WriteLine($"ich hab eie {pizzagröße}-Pizza genommen.");

            Pizzagröße pizzagröße1 = (Pizzagröße)3;

            //Wenn Enumator nicht belgt ist, 
            //dann ist Ergebnis beim Casten die Zahl selbst
            Console.WriteLine($"- Und ich hab eine {pizzagröße1}-Pizza genommen.");

            Pizzagröße pizzagröße2 = (Pizzagröße).3;


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_double
{
    class Ddouble
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### double literals ###");
            double kommaZahl = 34.455;

            Console.WriteLine("### double.Parse(string) ###");
            string dblAsString1 = "2,44";
            string dblAsString2 = "34.455";

            double dblFromString = double.Parse(dblAsString1);
            Console.WriteLine($"dblFromString: {dblFromString}"); // 2,44

            dblFromString = double.Parse(dblAsString2);
            Console.WriteLine($"dblFromString: {dblFromString}"); // 34455

            // Eingabe in der Konsole: gleich wie strings
            Console.Write("Geben Sie eine Dezimalzahl ein: ");
            dblFromString = double.Parse(Console.ReadLine());
            Console.WriteLine($"dblFromString: {dblFromString}");

            Console.WriteLine("### double.Parse(string, CultureInfo) ###");
            Console.Write("Geben Sie eine Dezimalzahl ein: ");
            dblFromString = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine($"dblFromString: {dblFromString}");
            // Mit Formatangabe 'InvariantCulture' wird auch die Zahl mit Punkt akzeptiet und geparset.

            Console.ReadKey();
        }
    }
}

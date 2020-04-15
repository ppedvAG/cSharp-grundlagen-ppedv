using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_string
{
    class Dstring
    {
        static void Main(string[] args)
        {
            // ########################################
            Console.WriteLine("### string anlegen ###");
            // es gibt mehrere Wege, wie man einen String-Wert bekommen kann
            string myString = Console.ReadLine();
            // Literale sind Zeichenkombinationen, die vom Compiler als String-Wert interpretiert werden.
            // Literale sind Möglichkeiten, string anzulegen, ohne auf etwaige Methoden oder Konstruktoren zuzugreifen.
            
            Console.WriteLine("# string anlegen : \"text\" #");
            myString = "text";
            Console.WriteLine($"myString: {myString}");


            Console.WriteLine("# string anlegen : $\"text\" #");

            myString = $"text {true}";
            Console.WriteLine($"myString: {myString}");


            Console.WriteLine("# string anlegen : escapes #");
            // aus einem besonderen Zeichen ein normales Zeichen machen:
            Console.WriteLine("anführungszeichen: \"");
            // aus einem normalen Zeichen ein besonderes Zeichen machen:
            Console.WriteLine("neue Zeile: \n");
            Console.WriteLine("\t tabulator");


            Console.ReadKey();
        }
    }
}

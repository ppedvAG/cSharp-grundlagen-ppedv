using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Console
{
    class DConsole
    {
        static void Main(string[] args)
        {
            int alter = 35;
            string name = "Vadzim";
            Console.WriteLine("Mein Name ist {0}, ich bin {1} Jahre alt.", name, alter);

            // Text ausgeben, ohne Zeilenumbruch
            Console.Write(name);

            Console.Write("Ihre Lieblingsfarbe: ");
            string eingabe;
            eingabe = Console.ReadLine();
            Console.WriteLine($"Sie haben eingegeben: {eingabe}");

            Console.WriteLine("Eurozeichen: €");
            Console.OutputEncoding = Encoding.UTF8;
            //Console.OutputEncoding = UTF8Encoding;

            Console.WriteLine("Eurozeichen mit UTF8: €");
           
            Console.ReadKey();
        }
    }
}

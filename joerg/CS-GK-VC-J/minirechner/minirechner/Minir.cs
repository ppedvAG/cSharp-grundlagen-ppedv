using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minirechner
{
    class Minir
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie eine Zahl ein: ");
            int intZahl = int.Parse(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie eine Zahl ein: ");
            double DoubZahl2 = double.Parse(Console.ReadLine());
            int summe = intZahl + (int)DoubZahl2;

            Console.WriteLine(summe);
            Console.ReadKey();

        }
    }
}

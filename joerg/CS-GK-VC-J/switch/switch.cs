using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Beispiel mit Monat, Hier soll Februar ausgegeben werden

            int monat = 5;

            switch (monat)
            {
                case 1:
                    Console.WriteLine("Januar");
                    break;

                case 2:
                    Console.WriteLine("Februar");
                    break;

                case 3:
                    Console.WriteLine("März");
                    break;
                    //Beispiel wenn der Monat nicht aufgeführt ist, quasi alles ab 4. Ausgabe des Default wertes...
                default:
                    Console.WriteLine("Fehlerhafter Monat");
                    break;


            }
                     Console.ReadKey();
        }
    }
}

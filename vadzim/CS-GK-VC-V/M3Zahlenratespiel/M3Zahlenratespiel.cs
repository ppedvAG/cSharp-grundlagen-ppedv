using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3Zahlenratespiel
{
    class M3Zahlenratespiel
    {
        static void Main(string[] args)
        {
            // Mit der Klasse Random lassen sich Zufallszahlen generieren
            Random random = new Random();
            int zufallszahl = random.Next(1, 6);
            Console.WriteLine($"zufallszahl: {zufallszahl}");
            Console.ReadKey();
        }
    }
}

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
            //Mit der Klasse Random lassen sich Zufallszahlen generieren
            Random random = new Random();
            // public virtual int Next(int minValue, int maxValue);
            int zufallszahl = random.Next(1, 6);
            int Eingabe;
            do
            {

                Console.WriteLine($"zufallszahl: {zufallszahl}");

                Console.WriteLine("Bitte geben sie eine Zahl zwischen 1 und 5 ein:");

                Eingabe = int.Parse(Console.ReadLine());



                if (Eingabe < zufallszahl)

                { Console.WriteLine("Deine Zahl ist kleiner die Zufallszahl!"); }

                if (Eingabe > zufallszahl)

                { Console.WriteLine("Deine Zahl ist größer als die Zufallszahl!"); }

                if (Eingabe == zufallszahl)

                { Console.WriteLine("Glückwunsch, Du hast die Richtige Zahl erraten!"); }
            
            }
            while (Eingabe != zufallszahl);

    Console.ReadKey();
        }

    }



}

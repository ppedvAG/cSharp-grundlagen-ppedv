using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_int
{
    class Dint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### int literals ###");
            int myInt1 = 4;
            int myInt2 = -5;
            int myInt3 = 0b_0000_0000_0000_0000_0000_0000_0000_1011; // 11

            Console.WriteLine("### int possible values ###");
            Console.WriteLine($"int.MinValue: {int.MinValue}"); // -2 147 483 648
            Console.WriteLine($"int.MaxValue: {int.MaxValue}"); // 2 147 483 647

            // myInt1 = (int)2147483649; 
            // Schon auf der Etappe von Kodieren kriegen wir die Fehlermeldung


            Console.WriteLine("### int.Parse(string) ###");
            string myInt4 = "2";
            myInt1 = int.Parse(myInt4);
            Console.WriteLine($"myInt1 is int: {myInt1 is int}"); //True


            Console.WriteLine("### (int)number ###");
            double kommazahl = 34.455;
            int ganzezahl = (int)kommazahl;
            Console.WriteLine($"ganzezahl: {ganzezahl}"); // 34


            Console.WriteLine("### int operators: > ###"); // <, >=, <=
            Console.WriteLine(2 > 2); //False

            Console.ReadKey();
        }
    }
}

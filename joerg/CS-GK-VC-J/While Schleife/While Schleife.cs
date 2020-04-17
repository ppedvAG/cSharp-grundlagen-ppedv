using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Schleife
{
    class Program
    {
        static void Main(string[] args)
        {
            //While-Schleifen
            int zahl = 1;

            while (zahl <= 5)
            {
                Console.WriteLine(zahl);
                zahl += 1;
            }
        Console.ReadKey(); 
        }
    }
}

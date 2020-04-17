using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Schleife
{
    class Program
    {
        static void Main(string[] args)
        {

            //Do-While-Schleifen

            int zahl = 0;

            do
            {
                zahl = zahl + 1;

                if (zahl == 4)
                {

                    continue;
                }
                Console.WriteLine(zahl);


            }
            while (zahl < 5);

            Console.ReadKey();
        }
    }
}

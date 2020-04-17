using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_for
{
    class Dfor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zähle bis 9");
            //for (int i = 0; i < 21; i = i +2)
            int Zahl1 = 0;
            int Zahl2 = 20;
            
                while(Zahl1 < Zahl2)
                {
                Console.WriteLine(Zahl1 += 1);
                }
                
            
        
            
            Console.ReadKey();
        }

    }
}

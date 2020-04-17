using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF
{
    class Program
    {
        static void Main(string[] args)
        {
            int alter = 17;

            if (alter >= 18)
            {
                Console.WriteLine("Du bist alt genug!");
            }
            else
            {
                //falls du nicht alt genug bist, den else Befehl hinzufügen. Wichtig, das int alter = muss unter if Alter 18 sein
                Console.WriteLine("Du bist nicht alt genug!");




            }

            Console.ReadKey();
        }



    }
}

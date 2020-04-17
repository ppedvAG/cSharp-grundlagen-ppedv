using Demo_Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lib_Consumer
{
    class DLibConsumer
    {
        static void Main(string[] args)
        {
            Person personMax = new Person("Herr", "Max", "Musternamm", 27);

            Console.WriteLine(personMax.stellDichVor());

            Console.WriteLine(personMax.Alter);

            Console.ReadKey();


        }
    }
}

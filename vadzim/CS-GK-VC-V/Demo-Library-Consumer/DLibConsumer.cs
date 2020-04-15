using Demo_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Library_Consumer
{
    class DLibConsumer
    {
        static void Main(string[] args)
        {
            //Demo_Library.MyClass myClass = new Demo_Library.MyClass();
            MyClass myClass = new MyClass();

            string str = myClass.GetFelder();
            Console.WriteLine(str);

            myClass.SetFelder("die Antwort ist: ", 43);

            str = myClass.GetFelder();
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}

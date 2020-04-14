using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_bool
{
    class Dbool
    {
        static void Main(string[] args)
        {
            // = Zuweisungsoperator
            bool myB1 = true;
            bool myB2 = false;
            bool myB3 = true;

            Console.WriteLine("### bool operators: == ###");
            // == Vergleichsoperator
            Console.WriteLine(myB1 == myB2); //False
            Console.WriteLine(2 == 2); //True
            Console.WriteLine("bla" == "blu"); //False  
            

            Console.WriteLine("### bool operators: != ###");
            // != Ungleich-Operator
            Console.WriteLine(myB1 != myB2); //True
            Console.WriteLine(2 != 2); //False


            Console.WriteLine("### bool operators: && ###"); //AND
            Console.WriteLine(myB1 == myB2 && myB1 == myB3); //False && True : False


            Console.WriteLine("### bool operators: || ###"); //OR
            Console.WriteLine(myB1 == myB2 || myB1 == myB3); //False || True : True
            Console.WriteLine(myB1 == myB3 || myB1 == myB3); //True || True : True


            Console.WriteLine("### bool operators: ^ ###"); //XOR, exclusive OR
            // Nur der linke oder der rechte Teil darf True sein
            Console.WriteLine(myB1 == myB2 ^ myB1 == myB3); //False ^ True : True
            Console.WriteLine(true ^ true); //True ^ True : False

            Console.ReadKey();
        }
    }
}

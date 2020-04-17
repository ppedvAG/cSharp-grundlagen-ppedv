using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lib
{
    public class Person
    {   //Eigenschaften / Properties
        public string Anrede { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public int Alter { get; set; }

        //Konstuktior der Klasse
        public Person(string anr, string v, string n, int a)
        {
            Anrede = anr;
            Vorname = v;
            Nachname = n;
            Alter = a;
        }
        //Methode der Klasse
        public string stellDichVor()
        {
            return $"Ich bin {Anrede} {Nachname}";


        }
    }
}

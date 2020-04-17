using M5Fahrzeug;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_FileAccess
{
    class DFileAccess
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("MeineDatei.txt");
            sw.WriteLine("Todo Liste: ");
            sw.WriteLine("- emails");
            sw.WriteLine("- einkaufen");
            sw.Close();

            StreamReader sr = new StreamReader("BMW.json");
            
            var auto = JsonConvert.DeserializeObject<Fahrzeug>(sr.ReadToEnd());
            sr.Close();
            Console.WriteLine(auto.BeschreibeMich());

            Fahrzeug audi = new Fahrzeug("Audi", 40000, 220);
            StreamWriter schreiber = new StreamWriter("BMW.json");

            schreiber.WriteLine(JsonConvert.SerializeObject(audi));
            // schreiber.WriteLine
            schreiber.Close();

            Console.ReadKey();
            
        }
    }
}

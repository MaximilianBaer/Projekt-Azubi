using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.IO;

namespace fizzbuzz
{
    class Programm
    {

        public static List<int> Start_Zahlen_testen(int untergrenze, int obergrenze)
        {
            var zahlen = Zahlen_original(untergrenze, obergrenze);
            return zahlen;
        }
        internal static List<int> Zahlen_original(int untergrenze, int obergrenze)
        {
            var zahlen = new List<int>();
            for (int zahl = untergrenze; zahl <= obergrenze; zahl++)
            {
                zahlen.Add(zahl);
            }
            return zahlen;
        }
        internal static Dictionary<string, string> fizzbuzz = new Dictionary<string, string>();
        internal static Dictionary<string, string> fizz = new Dictionary<string, string>();
        internal static Dictionary<string, string> buzz = new Dictionary<string, string>();
        internal class zahlen
        {

        }
        internal class fiz_logik
        {

        }
        internal class bus_logik
        {

        }
        internal class fizbuz_logik
        {
            int fizzbuzz_var;
            //var population = new Tuple<int, int, int, int, int, int, int>(4, 4, 4, 4, 4, 4, 4);
        }
        internal void fizbuz(int z1, int z2)
        {
            //[get Fizbuz_stufe_1 from fizbuz_logik]
            var erg = Start_Zahlen_testen(z1, z2);
            Dictionary<string, string> FIZBUS = new Dictionary<string, string>();
            foreach (int zahl_1 in erg)
            {
                /*FIZBUS.Add(Convert.ToString(zahl_1), fizbuz_stufe_1);*/
                Console.WriteLine("dfsd");
                Console.ReadLine();
            }
        }
        //internal static void fiz()
        //{
        //    //["Diktionary für fiz anlegen"]
        //return variable;
        //}
        //internal static void buz()
        //{
        //    //["Diktionary für bus anlegen"]
        //return variable;
        //}
        internal void Ausgabe(string ausg)
        {
            Console.WriteLine(ausg);
        }
        public void Main()
        {
            //[get eingabe]
            //[Ausgaben   ]
            fizbuz(1, 55);
        }
        //Thread hzz = new Thread(fizbuz);
        //hzz.Start.();

    }
}

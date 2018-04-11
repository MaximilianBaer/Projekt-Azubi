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
  
        //internal static IEnumerable<int> fizz_logik(int[] zahlen_fizzbuzz)
        //{
        //    return;
        //}
        //internal static IEnumerable<int> buzz_logik(int[] zahlen_fizzbuzz)
        //{
        //    return;
        //}
        internal static IEnumerable<int> fizzbuzz_logik(int[] zahlen_fizzbuzz)
        {
            IEnumerable<int> querry = from zahlen_fizb in zahlen_fizzbuzz where zahlen_fizb % 3 == 0 && zahlen_fizb % 5 == 0 select zahlen_fizb;
            return querry;
        }
        internal static void fizzbuzz_definition(int zahl1, int zahl2)
        {
            int[] fizzbuzz_stufe;
            var alle_zahlen = Start_Zahlen_testen(zahl1, zahl2);
            
            var fizzbuzz_vorstufe_1 = fizzbuzz_logik(alle_zahlen.ToArray());
            fizzbuzz_stufe = fizzbuzz_vorstufe_1.ToArray();

            for (int zahl_1 = 0; zahl_1 < fizzbuzz_stufe.Count(); zahl_1++ )
            {
                Console.WriteLine(fizzbuzz_stufe[zahl_1]);
                fizzbuzz.Add(Convert.ToString(fizzbuzz_stufe[zahl_1]), "FIZZBUZZ");
            }
            Console.ReadLine();
        }
        internal static void fizz_definition(int zahl1,int zahl2)
        {
           //
        
        }
        internal static void buzz_definiton(int zahl1, int zahl2)
        {
            
        
        }
        internal void Ausgabe(string ausg)
        {
            Console.WriteLine(ausg);
        }
        public static void Main()
        {
            
            fizzbuzz_definition(3, 20000);
        }
    }
}

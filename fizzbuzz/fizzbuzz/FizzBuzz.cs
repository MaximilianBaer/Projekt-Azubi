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

        internal static IEnumerable<int> fizz_logik(int[] zahlen_fizzbuzz)
        {
            IEnumerable<int> querry = from zahlen_fizb in zahlen_fizzbuzz where zahlen_fizb % 3 == 0 select zahlen_fizb;
            return querry;
        }
        internal static IEnumerable<int> buzz_logik(int[] zahlen_fizzbuzz)
        {
            IEnumerable<int> querry = from zahlen_fizb in zahlen_fizzbuzz where zahlen_fizb % 5 == 0 select zahlen_fizb;
            return querry;
        }
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
                fizzbuzz.Add(Convert.ToString(fizzbuzz_stufe[zahl_1]), "FIZZBUZZ");
            }
            
        }
        internal static void fizz_definition(int zahl1,int zahl2)
        {
            int[] fizz_stufe;
            var alle_zahlen = Start_Zahlen_testen(zahl1, zahl2);

            var fizz_vorstufe_1 = fizz_logik(alle_zahlen.ToArray());
            fizz_stufe = fizz_vorstufe_1.ToArray();

            for (int zahl_1 = 0; zahl_1 < fizz_stufe.Count(); zahl_1++)
            {
                fizz.Add(Convert.ToString(fizz_stufe[zahl_1]), "FIZZ");
            }
            
        }
        internal static void buzz_definiton(int zahl1, int zahl2)
        {
            int[] buzz_stufe;
            var alle_zahlen = Start_Zahlen_testen(zahl1, zahl2);

            var buzz_vorstufe_1 = buzz_logik(alle_zahlen.ToArray());
            buzz_stufe = buzz_vorstufe_1.ToArray();

            for (int zahl_1 = 0; zahl_1 < buzz_stufe.Count(); zahl_1++)
            {
                buzz.Add(Convert.ToString(buzz_stufe[zahl_1]), "BUZZ");
            }
            
        }
        internal static void Ausgabe(int zahl1, int zahl2)
        {
            var alle_zahlen = Start_Zahlen_testen(zahl1, zahl2);
            string Endausgabe;
            for (int zahl_1 = 0; zahl_1 < alle_zahlen.Count(); zahl_1++)
            {

                bool fiz, buz, fizbuz;
                string stufe_fizz = Convert.ToString(alle_zahlen[zahl_1]);

                try
                {
                    Endausgabe = fizz[Convert.ToString(zahl_1)];
                    f iz == true;
                    
                    Console.WriteLine(Endausgabe);
                }
                catch
                {
                    Console.WriteLine(zahl_1);
                }
                try
                {
                    Endausgabe = buzz[Convert.ToString(zahl_1)];
                }
                catch
                {

                }
                try
                {
                    Endausgabe = fizzbuzz[Convert.ToString(zahl_1)];
                }
                catch
                {

                }
            }
            Console.ReadLine();
        }
        public static void Main()
        {
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            int zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            fizzbuzz_definition(zahl1, zahl2);
            fizz_definition(zahl1, zahl2);
            buzz_definiton(zahl1, zahl2);
            Ausgabe(zahl1, zahl2);
        }
    }
}

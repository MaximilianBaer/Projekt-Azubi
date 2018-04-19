using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baeuernmultiplikator
{
    public class Bauernmultiplikator
    {
        static void Main(string[] args)
        {
            start:
            int[] zahl = eingabe();
            int ausgabe = Multipliziere(zahl[0], zahl[1]);
            Ausgabe(ausgabe);
            goto start;
            
        }
        internal static void Ausgabe(int zahl_ausgabe)
        {
            Console.WriteLine(zahl_ausgabe);
        }
        internal static int[] eingabe()
        {
            Console.Write("Geben sie eine zahl ein: ");
            int[] zahlen = new int[2];
            zahlen[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geben sie eine weitere zahl ein: ");
            zahlen[1] = Convert.ToInt32(Console.ReadLine());
            return zahlen;
        }
        public static int Multipliziere(int zahl_1, int zahl_2)
        {
            int anzahl = zaehler(zahl_1);
            int[,] array = teiler(zahl_1, zahl_2, anzahl);
            List<int> alle_zahlen = filter(array);
            int ergebnis = zusammenrechnen(alle_zahlen);
            return ergebnis;
        }
        internal static int zaehler(double zahl)
        {
            int zaehelr = 1;
            do
            {
                zahl = Convert.ToInt32(Math.Floor(zahl / 2));
                zaehelr++;
            } while (zahl != 1);
            return zaehelr;
        }
        internal static int[,] teiler(double zahl1, int zahl2, int anzahl)
        {
            int[,] zahle_getennt = new int[2, anzahl+1];
            zahle_getennt[0, 0] = Convert.ToInt32(zahl1);
            zahle_getennt[1, 0] = zahl2;
            for (int i = 0; i < anzahl; i++)
            {
                
                zahle_getennt[0, i + 1]= Convert.ToInt32(Math.Floor(zahl1 / 2));
                zahl1 = Convert.ToInt32(Math.Floor(zahl1 / 2));    
                zahle_getennt[1, i + 1] = zahl2 * 2;
                zahl2 = zahl2 * 2;
            }
            return zahle_getennt;
        }
        internal static List<int> filter(int[,] zahlen)
        {
            List<int> zahl = new List<int>();
            for (int i = 0; i < (zahlen.Length / 2); i++)
            {
                if (!(zahlen[0,i] % 2 == 0))
                {
                    zahl.Add(zahlen[1, i]);
                }
            }
            return zahl;
        }
        internal static int zusammenrechnen(List<int> alle_zahlen)
        {
            int[] zahlen_alle = alle_zahlen.ToArray();
            int zahl = 0;
            for (int i = 0; i < zahlen_alle.Count(); i++)
            {
                zahl = zahl + zahlen_alle[i];
            }
            return zahl;
        }
    }
}

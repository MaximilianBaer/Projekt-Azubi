using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace froehliche_zahlen
{
    public class Fröhliche_Zahlen
    {
        public static void Main()
        {
            Console.WriteLine(Zahleneingabe(19));
            
        }
        public static string Zahleneingabe(int Eingangszahl)
        {
            bool Ergebnis = Prüfung(Eingangszahl);
            string Ausgang = Test_froh_traurig(Ergebnis);
            return Ausgang;
        }

        internal static string Test_froh_traurig(bool Eingang)
        {
            string Ausgang;
            if (Eingang)
            {
                Ausgang = "Fröhliche Zahl";
            }
            else
            {
                Ausgang = "Traugrige Zahl";
            }
            return Ausgang;
        }
        internal static bool Prüfung(int Einganzahl)
        {
            do
            {
                string Ergebnis_string = Einganzahl.ToString();
                int Anzahl_stellen = Ergebnis_string.Length;
                int[] Zahlen_getrent = new int[Anzahl_stellen];
                int zahl_zum_rechnen = 0;
                for (int i = 0; i < Anzahl_stellen; i++)
                {
                    Zahlen_getrent[i] = (Einganzahl % Convert.ToInt32(Math.Pow(10, Convert.ToDouble(i + 1)))/ Convert.ToInt32(Math.Pow(10, Convert.ToDouble(i))));
                }
                for (int i = 0; i < Zahlen_getrent.Count(); i++)
                {
                    zahl_zum_rechnen = zahl_zum_rechnen + Convert.ToInt32(Math.Pow(Zahlen_getrent[i], 2));
                }
                Einganzahl = zahl_zum_rechnen;
            } while (Einganzahl != 4 && Einganzahl != 1);
            if (Einganzahl == 4)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

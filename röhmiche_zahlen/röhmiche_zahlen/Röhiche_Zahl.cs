using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace röhmiche_zahlen
{
    public class Röhiche_Zahl
    {
        public static string Eingabe(int eingabe)
        {
            int[] Zahlen = umwandlung_schrit_1(eingabe);
            string römmich_zahl = umwandlung_schrit_2(Zahlen, eingabe);
            return römmich_zahl;
        }
        internal static int[] umwandlung_schrit_1(int eingabe)
        {
            string Ergebnis_string = eingabe.ToString();
            int Anzahl_stellen = Ergebnis_string.Length;
            int[] Zahlen_getrent = new int[Anzahl_stellen];
            for (int i = 0; i < Anzahl_stellen; i++)
            {
                Zahlen_getrent[i] = (eingabe % Convert.ToInt32(Math.Pow(10, Convert.ToDouble(i + 1))) / Convert.ToInt32(Math.Pow(10, Convert.ToDouble(i))));
            }
            return Zahlen_getrent;
        }
        internal static string umwandlung_schrit_2(int[] zahlen, int eingabe)
        {
            string zahlen_R = "";
            for (int ziffer = 0; ziffer < zahlen.Length; ziffer++)
            {
                switch (ziffer)
                {
                    case 0:
                        switch (zahlen[ziffer])
                        {
                            case 0:
                                break;
                            case 1:
                                zahlen_R = "I";
                                break;
                            case 2:
                                zahlen_R = "II";
                                break;
                            case 3:
                                zahlen_R = "III";
                                break;
                            case 4:
                                zahlen_R = "IV";
                                break;
                            case 5:
                                zahlen_R = "V";
                                break;
                            case 6:
                                zahlen_R = "VI";
                                break;
                            case 7:
                                zahlen_R = "VII";
                                break;
                            case 8:
                                zahlen_R = "VIII";
                                break;
                            case 9:
                                zahlen_R = "IX";
                                break;

                        }
                        break;
                    case 1:
                        switch (zahlen[ziffer])
                        {
                            case 0:
                                break;
                            case 1:
                                zahlen_R = "X" + zahlen_R;
                                break;
                            case 2:
                                zahlen_R = "XX" + zahlen_R;
                                break;
                            case 3:
                                zahlen_R = "XXX" + zahlen_R;
                                break;
                            case 4:
                                zahlen_R = "XL" + zahlen_R;
                                break;
                            case 5:
                                zahlen_R = "L" + zahlen_R;
                                break;
                            case 6:
                                zahlen_R = "LX" + zahlen_R;
                                break;
                            case 7:
                                zahlen_R = "LXX" + zahlen_R;
                                break;
                            case 8:
                                zahlen_R = "LXXX" + zahlen_R;
                                break;
                            case 9:
                                zahlen_R = "XC" + zahlen_R;
                                break;
                        }
                        break;
                    case 2:
                        switch (zahlen[ziffer])
                        {
                            case 0:
                                break;
                            case 1:
                                zahlen_R = "C" + zahlen_R;
                                break;
                            case 2:
                                zahlen_R = "CC" + zahlen_R;
                                break;
                            case 3:
                                zahlen_R = "CCC" + zahlen_R;
                                break;
                            case 4:
                                zahlen_R = "CD" + zahlen_R;
                                break;
                            case 5:
                                zahlen_R = "D" + zahlen_R;
                                break;
                            case 6:
                                zahlen_R = "DC" + zahlen_R;
                                break;
                            case 7:
                                zahlen_R = "DCC" + zahlen_R;
                                break;
                            case 8:
                                zahlen_R = "DCCC" + zahlen_R;
                                break;
                            case 9:
                                zahlen_R = "CM" + zahlen_R;
                                break;

                        }
                        break;
                    case 3:
                        switch (zahlen[ziffer])
                        {
                            case 0:
                                break;
                            case 1:
                                zahlen_R = "M" + zahlen_R;
                                break;
                            case 2:
                                zahlen_R = "MM" + zahlen_R;
                                break;
                            case 3:
                                zahlen_R = "MMM" + zahlen_R;
                                break;
                            case 4:
                                zahlen_R = "zu groß";
                                break;
                            case 5:
                                zahlen_R = "zu groß";
                                break;
                            case 6:
                                zahlen_R = "zu groß";
                                break;
                            case 7:
                                zahlen_R = "zu groß";
                                break;
                            case 8:
                                zahlen_R = "zu groß";
                                break;
                            case 9:
                                zahlen_R = "zu groß";
                                break;
                        }
                        break;
                }
            }
            if (eingabe > 3000) { zahlen_R = "zu groß"; }
            return zahlen_R;
        }
    }
}

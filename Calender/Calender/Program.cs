using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.Write("C:> ");
            string Eingabe = Console.ReadLine();
            bool Prüfwert = Prüfen(Eingabe);
            string[] getrente_Eingabe = Eingabe_trennen(Eingabe);
            string[] neu_eingabe = sortierer(getrente_Eingabe);
            string[] befehl = ausfüllen(neu_eingabe);
            int anzahl = anzahl_tage(befehl);
            int tage_index = tag_index(befehl);
            int erstertag = erster_tag(befehl);
            string[,] tag = tage();
            int leer = leere_tage(erstertag, tage_index);
            string[] tage_array = array_tag(leer, anzahl);

            string Ausgabe = calender(befehl, Prüfwert,tage_index, tag, tage_array);
            Console.WriteLine(Ausgabe);
            goto start;
            
        }
        internal static bool Prüfen(string prüfung)
        {
            if (prüfung.Contains("cal"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static string[] Eingabe_trennen(string eingabe)
        {   //[0]: cal // [1]: monat // [2]: jahr // [3]: Tag // [4]: Hilfsvariable 
            string[] eingabe_getrennt = new string[5];
            eingabe = eingabe + " ";
            eingabe_getrennt[0] = eingabe.Substring(0, eingabe.IndexOf(" "));
            eingabe = eingabe.Substring(eingabe.IndexOf(" ")+1);
            eingabe = eingabe + " ";
            eingabe_getrennt[1] = eingabe.Substring(0, eingabe.IndexOf(" "));
            eingabe = eingabe.Substring(eingabe.IndexOf(" ")+1);
            eingabe = eingabe + " ";
            eingabe_getrennt[2] = eingabe.Substring(0, eingabe.IndexOf(" "));
            eingabe = eingabe.Substring(eingabe.IndexOf(" ")+1);
            eingabe_getrennt[3] = Convert.ToString(eingabe.Trim(Convert.ToChar(" ")));
            string[] eingabe_getrennt_ende = syntax(eingabe_getrennt);
            return eingabe_getrennt_ende;
        }

        internal static string[] syntax(string[] eingabe_getrennt)
        {
            if (eingabe_getrennt[1] == "" || eingabe_getrennt[2] == "" || eingabe_getrennt[3] == "")
            {
                if (eingabe_getrennt[1] == "" && eingabe_getrennt[2] == "" && eingabe_getrennt[3] == "")
                {
                    eingabe_getrennt[4] = "nur_befehl";
                }
                else if (eingabe_getrennt[2] == "" && eingabe_getrennt[3] == "")
                {
                    int res;
                    bool result = Int32.TryParse(eingabe_getrennt[1], out res);
                    if (result)
                    {
                        eingabe_getrennt[4] = "ohne_tag";
                    }
                    else
                    {
                        eingabe_getrennt[4] = "mit_tag";
                    }
                }
                else if (eingabe_getrennt[3] == "")
                {
                    int res;
                    bool result = Int32.TryParse(eingabe_getrennt[2], out res);
                    if (result)
                    {
                        eingabe_getrennt[4] = "monat_ohne_tag";
                    }
                    else
                    {
                        eingabe_getrennt[4] = "monat_mit_tag";
                    }
                }
            }
            return eingabe_getrennt;
        }

        internal static string[] sortierer(string[] neue_eingabe)
        {
            if (neue_eingabe[4] == "nur_befehl")
            {
                neue_eingabe[3] = "Montag";
            }
            else if (neue_eingabe[4] == "monat_ohne_tag")
            {
                // cal 4 2018
                neue_eingabe[3] = "Montag";
            }
            else if (neue_eingabe[4] == "monat_mit_tag")
            {
                //cal 4 montag
                neue_eingabe[3] = neue_eingabe[2];
                neue_eingabe[2] = "";

            }
            else if (neue_eingabe[4] == "ohne_tag")
            {
                // cal 4
                neue_eingabe[3] = "Montag";

            }
            else if (neue_eingabe[4] == "mit_tag")
            {
                // cal montag
                neue_eingabe[3] = neue_eingabe[1];
                neue_eingabe[1] = "";    
            }
            return neue_eingabe;
        }
        internal static string[] ausfüllen(string[] befehl)
        {
            DateTime jetzt = DateTime.Now;
            if (befehl[1] == "")
            {
                befehl[1] = Convert.ToString(jetzt.Month);
            }
            if (befehl[2] == "")
            {
                befehl[2] = Convert.ToString(jetzt.Year);
            }
            return befehl;
        }
        internal static string[,] tage()
        {
            string[,] tag_nr = new string[7,7] { 
                { "Mo", "Di", "Mi", "Do", "Fr", "Sa", "So" },
                { "Di", "Mi", "Do", "Fr", "Sa", "So", "Mo" }, 
                { "Mi", "Do", "Fr", "Sa", "So", "Mo", "Di" },
                { "Do", "Fr", "Sa", "So", "Mo", "Di", "Mi" },
                { "Fr", "Sa", "So", "Mo", "Di", "Mi", "Do" }, 
                { "Sa", "So", "Mo", "Di", "Mi", "Do", "Fr" },
                { "So", "Mo", "Di", "Mi", "Do", "Fr", "Sa" }
            };
            return tag_nr;
        }
        internal static int tag_index(string[] eigabe)
        {
            if (eigabe[3] == "Sonntag")
            {
                return 6;
            }
            else if (eigabe[3] == "Dienstag")
            {
                return 1;
            }
            else if (eigabe[3] == "Mittwoch")
            {
                return 2;
            }
            else if (eigabe[3] == "Donnerstag")
            {
                return 3;
            }
            else if (eigabe[3] == "Freitag")
            {
                return 4;
            }
            else if (eigabe[3] == "Samstag")
            {
                return 5;
            }
            else
            {
                return 0;
            }

        }
        internal static int anzahl_tage(string[] eingabe)
        {
            int tage_anzahl = DateTime.DaysInMonth(Convert.ToInt32(eingabe[2]), Convert.ToInt32(eingabe[1]));
            return tage_anzahl;
        }
        internal static int erster_tag(string[] eingabe)
        {
            DateTime erster = new DateTime(Convert.ToInt32(eingabe[2]), Convert.ToInt32(eingabe[1]), 1);
            string tag = Convert.ToString(erster.DayOfWeek);
            int index_erster_tag;
            if (tag == "Monday")
            {
                index_erster_tag = 0;
            }
            else if (tag == "Tuesday")
            {
                index_erster_tag = 1;
            }
            else if (tag == "Wednesday")
            {
                index_erster_tag = 2;
            }
            else if (tag == "Thursday")
            {
                index_erster_tag = 3;
            }
            else if (tag == "Friday")
            {
                index_erster_tag = 4;
            }
            else if (tag == "Saturday")
            {
                index_erster_tag = 5;
            }
            else 
            {
                index_erster_tag = 6;
            }
            return index_erster_tag;
        }
        internal static int leere_tage(int erster_tag, int tagindex )
        {
            int tage_verschieben = erster_tag - tagindex;
            if (tage_verschieben < 0)
            {
                tage_verschieben = tage_verschieben + 7;
            }
            return tage_verschieben;
        }
        internal static string[] array_tag(int tage_verschieben, int anzahl_tage)
        {
            string[] tage_array = new string[anzahl_tage + tage_verschieben];
            for (int i = 0; i < tage_verschieben; i++)
            {
                tage_array[i] = "  ";
            }
            for (int i = 0; i < anzahl_tage; i++)
            {
                tage_array[i + tage_verschieben] = Convert.ToString(i + 1);
            }
            for (int i = 0; i < tage_array.Length; i++)
            {
                if (tage_array[i].Length == 1)
                {
                    tage_array[i] = "0" + tage_array[i];
                }
            }
            return tage_array;
        }
        internal static string calender(string[] eingabe, bool Prüfwert, int tagindex, string[,] tage, string[] tage_array)
        {
            if (Prüfwert == false) { return "Befehl " + '"' + eingabe[0] + '"' + " ist nicht vorhanden."; }

            string reihe_1 = tage[tagindex,0]+" "+ tage[tagindex, 1] +" "+ tage[tagindex, 2] +" "+ tage[tagindex, 3] +" "+ tage[tagindex, 4] +" "+ tage[tagindex, 5] +" "+ tage[tagindex, 6];
            string linie = "--------------------";
            string reihe_2 = tage_array[0] + " " + tage_array[1] + " " + tage_array[2] + " " + tage_array[3] + " " + tage_array[4] + " " + tage_array[5] + " " + tage_array[6];
            string reihe_3 = tage_array[7] + " " + tage_array[8] + " " + tage_array[9] + " " + tage_array[10] + " " + tage_array[11] + " " + tage_array[12] + " " + tage_array[13];
            string reihe_4 = tage_array[14] + " " + tage_array[15] + " " + tage_array[16] + " " + tage_array[17] + " " + tage_array[18] + " " + tage_array[19] + " " + tage_array[20];
            string reihe_5 = tage_array[21] + " " + tage_array[22] + " " + tage_array[23] + " " + tage_array[24] + " " + tage_array[25] + " " + tage_array[26] + " " + tage_array[27];
            string reihe_6 = "";
            for (int i = 0; i < tage_array.Length - 28 ; i++)
            {
                if (i <=6)
                {
                    reihe_6 = reihe_6 +tage_array[i+28] + " ";
                }
            }
            string reihe_7 = "";
            for (int i = 0; i < tage_array.Length - 35; i++)
            {
                if (i <= 6)
                {
                    reihe_7 = reihe_7 + tage_array[i + 35] + " ";
                }
            }
            string ausgabe_ende = Environment.NewLine + reihe_1+ Environment.NewLine + linie + Environment.NewLine + reihe_2 + Environment.NewLine + reihe_3 + Environment.NewLine + reihe_4 + Environment.NewLine + reihe_5 + Environment.NewLine + reihe_6 + Environment.NewLine + reihe_7;
            return ausgabe_ende;
        }
        
    }
}

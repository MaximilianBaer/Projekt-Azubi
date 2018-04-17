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
            string Ausgabe = calender(befehl, Prüfwert);
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
        internal static string calender(string[] eingabe, bool Prüfwert)
        {
            
            if (Prüfwert == false) { return "Befehl "+'"'+ eingabe[0] +'"'+" ist nicht vorhanden.";}
            Console.WriteLine(eingabe);

            string[] tage = { "Mo", "Di", "Mi", "Do", "Fr", "Sa", "So" };
            int tage_anzahl = DateTime.DaysInMonth(Convert.ToInt32(eingabe[1]), Convert.ToInt32(eingabe[2]));
            DateTime erstr = new DateTime(Convert.ToInt32(eingabe[1]), Convert.ToInt32(eingabe[2]), 1);
            //string Erster_tag = DateTime.;
            
            




            return "[Calender Einfügen]";
        }
        
    }
}

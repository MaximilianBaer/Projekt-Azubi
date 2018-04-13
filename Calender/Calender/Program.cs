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
            string Ausgabe = calender(getrente_Eingabe, Prüfwert);
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
        {
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

            if (eingabe_getrennt[1] == "" || eingabe_getrennt[2] == "" || eingabe_getrennt[3] == "")
            {
                if(eingabe_getrennt[1] == "" && eingabe_getrennt[2] == "" && eingabe_getrennt[3] == "")
                {
                    eingabe_getrennt[4] = "nur_befehl";
                }
                else if (eingabe_getrennt[2] == "" && eingabe_getrennt[3] == "")
                {
                    if (true)
                    {
                        eingabe_getrennt[4] = "mit_tag";
                    }
                    else
                    {
                        eingabe_getrennt[4] = "ohne tag";
                    }
                }
                else if (eingabe_getrennt[3] == "")
                {
                    if (true)
                    {

                    }
                    else
                    {

                    }
                }
            }
            Console.WriteLine(eingabe_getrennt[0] + "h");
            Console.WriteLine(eingabe_getrennt[1] + "h");
            Console.WriteLine(eingabe_getrennt[2] + "h");
            Console.WriteLine(eingabe_getrennt[3] + "h");
            return eingabe_getrennt;
        }
        internal static string calender(string[] eingabe, bool Prüfwert)
        {
            
            if (Prüfwert == false) { return "Befehl "+'"'+ eingabe[0] +'"'+" ist nicht vorhanden.";}
            int jahr = 4;
            int monat = 4;
            int tag = 0;
            string woche_startet_am = "Mo";
            int tage_anzahl = DateTime.DaysInMonth(monat, jahr);
            DateTime erstr = new DateTime(jahr, monat, 1);
            //string Erster_tag = DateTime.;
            
            




            return "[Calender Einfügen]";
        }
        
    }
}

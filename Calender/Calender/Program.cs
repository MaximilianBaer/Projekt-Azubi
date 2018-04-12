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
            Console.Write("c:> ");
            string Eingabe = Console.ReadLine();
            bool Prüfwert = Prüfen(Eingabe);
            string Ausgabe = calender(Eingabe, Prüfwert);
            Console.WriteLine(Ausgabe);
            goto start;
            
        }
        internal static string calender(string eingabe, bool Prüfwert)
        {

            if (Prüfwert == false) { return "Befehl "+'"'+ Convert.ToString(eingabe.Split(Convert.ToChar(" "))) +'"'+" nicht vorhanden.";}







            return "[Calender Einfügen]";
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
    }
}

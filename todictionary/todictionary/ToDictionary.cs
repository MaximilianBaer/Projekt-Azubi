using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todictionary
{
    public class ToDictionary
    {
        public static void eingabe(string eingabe)
        {
            einfügen.einfüg(eingabe);
        }
        public static string auslesen(string Eingabe)
        {
            string übersetzung = Wörterbuch.Das_wörterbuch[Eingabe];
            return übersetzung;
        }
    }
    public class Wörterbuch
    {
        public static Dictionary<string, string> Das_wörterbuch;
    }
    internal class einfügen
    {
        internal static void einfüg(string eingabe)
        {
            int anzahl = einaben_zählen(eingabe);
            string[] eingabe_array = trennen_stufe_1(eingabe, anzahl);
            string[,] eingabe_getrennt = trennen(eingabe_array, anzahl);
            Dictionary<string, string> wörterbuch = impementation(eingabe_getrennt);
            Wörterbuch.Das_wörterbuch = wörterbuch;
        }
        internal static int einaben_zählen(string eingabe)
        {
            int anzahl = eingabe.Count(c => c == ';');
            //anzahl = anzahl - eingabe.Count(c => c == ';;');
            return anzahl + 1;
        }
        internal static string[] trennen_stufe_1(string eingabe, int anzahl)
        {
            string[] eingabe_getrennt = new string[anzahl];
            for (int i = 0; i < anzahl; i++)
            {
                try
                {
                    eingabe_getrennt[i] = eingabe.Substring(0, eingabe.IndexOf(";"));
                    eingabe = eingabe.Substring(eingabe.IndexOf(";")+1);
                    eingabe = eingabe.Trim(';');
                }
                catch
                {
                    
                        eingabe_getrennt[i] = eingabe.Substring(0);
                    
                    
                }
            }
            return eingabe_getrennt;
        }
        internal static string[,] trennen(string[] eingabe,int anzahl)
        {
            string[,] eingabe_getrennt = new string[anzahl, 2];
            for (int i = 0; i < anzahl; i++)
            {
                eingabe_getrennt[i, 0] = eingabe[i].Substring(0, eingabe[i].IndexOf("="));
                eingabe_getrennt[i, 1] = eingabe[i].Substring(eingabe[i].IndexOf("=") +1 );
            }
            return eingabe_getrennt;
        }
        internal static Dictionary<string, string> impementation(string[,] eingabe)
        {
            Dictionary<string, string> wörterbuch = new Dictionary<string, string>();
            for (int i = 0; i < (eingabe.Length / 2); i++)
            {
                wörterbuch.Add(eingabe[i, 0], eingabe[i,1]);
            }
            return wörterbuch; ; 
        }
    }
}

/* 
 
               ,---. 
            ,.'-.   \ 
           ( ( ,'"""""-. 
           `,X          `. 
           /` `           `._ 
          (            ,   ,_\ 
          |          ,---.,'o `. 
          |         / o   \     ) 
           \ ,.    (      .____,         ____________
            \| \    \____,'     \      /             \
          '`'\  \        _,____,'     (   Cleancode!  )
          \  ,--      ,-'     \        \ ____________/
            ( C     ,'         \      / /
             `--'  .'           |    <_/
               |   |         .O | 
             __|    \        ,-'_ 
            / `L     `._  _,'  ' `. 
           /    `--.._  `',.   _\  ` 
           `-.       /\  | `. ( ,\  \ 
          _/  `-._  /  \ |--'  (     \ 
         '  `-.   `'    \/\`.   `.    ) 
               \  -hrr-    \ `.  |    | 
*/
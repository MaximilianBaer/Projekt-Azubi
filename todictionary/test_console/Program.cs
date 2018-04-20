using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todictionary;


namespace test_console
{
    class Program
    {
        static void Main(string[] args)
        {


            ToDictionary.eingabe("g=2;h=2");
            string ergebnis = ToDictionary.auslesen("b");
            Console.WriteLine(ergebnis);
            Console.ReadLine();
        }
    
    }
}

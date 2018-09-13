using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromRomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bitte Geben sie eine Romische Zahl ein oder exit: ");
                var romanString = Console.ReadLine();
                if (romanString == "exit") break;
                var arab = FromRoman(romanString);
                Console.WriteLine(arab);
            }
        }
        public static int? FromRoman(string roman)
        {


            return roman.Length;
        }
    }
}

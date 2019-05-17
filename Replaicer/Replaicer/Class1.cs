using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Replaicer
{
    public class VowelMutationCounter
    {
        public static int UmlautsCounter(string input)
        {
            var goodinput = input.ToLower();
            var AO = goodinput.Replace("ä", "ae");
            var OE = AO.Replace("ö", "oe");
            var UE = OE.Replace("ü", "ue");
            int Count = CountUmlauts(UE);
            return Count;
        }

        private static int CountUmlauts(string ue)
        {
            var a = ue.Count(ae => ae == 'a');
            var e = ue.Count(ae => ae == 'e');
            var i = ue.Count(ae => ae == 'i');
            var o = ue.Count(ae => ae == 'o');
            var u = ue.Count(ae => ae == 'u');
            return a + e + i + o + u;
        }
    }
}

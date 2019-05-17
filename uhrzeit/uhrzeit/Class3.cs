using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace uhrzeit
{
    public class Class3
    {
        public static string checkOK(string stringTime)
        {
            
            var time = Cutter(stringTime);
            var hourOK = CheckHour(time[0]);
            var minutOK = CheckMinute(time[1]);
            var returnString = GetReturnString(minutOK, hourOK);
            return returnString;

        }

        private static string GetReturnString(bool minutOk, bool hourOk)
        {
            return minutOk && hourOk ? "ok" : "Error";
        }

        private static bool CheckHour(int i)
        {
            return i >= 0 && i <= 23;
        }

        private static bool CheckMinute(int i)
        {
            return i >= 0 && i <= 59;
        }

        private static int[] Cutter(string time)
        {
            var a = time.Split(':');
            var isBroken = Analyzer(a);
            var repairedA = Repair(a, isBroken);
            return Array.ConvertAll(repairedA, int.Parse);
        }

        private static string[] Repair(string[] strings, bool isBroken)
        {
            if (isBroken)
            {
                return new string[] {"99", "99"};
            }
            else
            {
                return strings;
            }
        }

        private static bool Analyzer(string[] strings)
        {
            foreach (var a in strings)
            {
                if (a == "")
                {
                    return !false;
                }
            }

            return false;
        }
    }
}

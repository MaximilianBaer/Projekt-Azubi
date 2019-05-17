using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace hallo
{
    public class NumberLister
    {
        public string GetReturn(string input)
        {
            
            var ListNumbers = CreateList(input);
            var returnText = GetReturnText(ListNumbers);
            returnText = ValidateInput(input, returnText);
            return returnText;
        }

        private string ValidateInput(string input, string p)
        {
            bool countOK = CheckCount(input);
            bool IntegretyOK = CheckIntegrety(input);

            return countOK && IntegretyOK ? p : "wrong Format";

        }

        private bool CheckIntegrety(string o)
        {
            return CheckNoEmpty(o) && CheckOnlyNumbers(o);
        }

        private bool CheckNoEmpty(string input)
        {
            var a = DeSpacer(input);
            var b = ToArray(a);
            var h = b.Count(d => d == "") == 0;
            return h;

        }

        private bool CheckOnlyNumbers(string input)
        {
            string index =  "1234567890,";
            return input.IndexOf(index) < 0;
        }

        private bool CheckCount(string o)
        {
            return o.Count(d => d == ',') >= 5;
        }

        private string GetReturnText(int[] listNumbers)
        {
            var sortedList = listNumbers.OrderBy( f => f).ToArray();
            return sortedList[0].ToString() +","+ sortedList[1].ToString() +","+ sortedList[2].ToString();
        }

        private int[] CreateList(string input)
        {
            var deSpaced =  DeSpacer(input);
            var output = ToArray(deSpaced);
            return StringToInt(output);
        }

        private string[] ToArray(string deSpaced)
        {
            var output = deSpaced.Split(',');
           return output;
        }

        private string DeSpacer(string input)
        {
            var output = input.Replace(" ", "");
            return output;
        }

        private int[] StringToInt(string[] output)
        {
            try
            {
                int[] outputInt = Array.ConvertAll(output, int.Parse);
                return outputInt;
            }
            catch (Exception e)
            {
                return new[] {0, 0, 0};
            }

        }
    }
}

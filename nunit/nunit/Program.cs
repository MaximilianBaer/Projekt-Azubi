using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace nunit
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static int TestTest(int a)
        {
            return a + 3;
        }
    }

    public class P1Test
    {
        public static string Test1(string input)
        {
            var result = Evaluate(input);
            var returnText = GetReturnText(result);
            return returnText;
        }

        private static string GetReturnText(bool input)
        {
            var returnText = input ? "yes" : "no";
            return returnText;
        }

        private static bool Evaluate(string input)
        {
            var numbers = Cutter(input);
            var result = Check(numbers);
            return result;
        }

        private static bool Check(int[] numbers)
        {
            var sequence1 = CreateSequence(numbers[0], numbers.Count());
            var sequence2 = CreateSequenceReverse(numbers[0], numbers.Count());
            var returnValue = CheckSequences(numbers, sequence1, sequence2);
            return returnValue;
        }

        private static bool CheckSequences(int[] numbers, int[] sequence1, int[] sequence2)
        {
            var returnValue = numbers.SequenceEqual(sequence1) || numbers.SequenceEqual(sequence2);
            return returnValue;
        }

        private static int[] CreateSequenceReverse(int i, int count)
        {
            var sequence = new int[count];

            for (var j = 0; j < count; j++)
            {
                sequence[j] = i - j;
            }

            return sequence;
        }

        private static int[] CreateSequence(int i, int count)
        {
            var sequence = new int[count];

            for (var j = 0; j < count; j++)
            {
                sequence[j] = j + i;
            }

            return sequence;
        }

        private static int[] Cutter(string input)
        {
            var a = input.Split('-');
            var b = Array.ConvertAll(a, int.Parse);
            return b;
        }
    }

    public class P2Test
    {
        public static int Test2()
        {
            var a = Reader.Readerer();
            var b = a.Length;
            return b;
        }

        public static string Test3()
        {
            var a = Reader.Readerer().ToList();
            var b = a.OrderBy(f => f.Length);
            var c = b.Last();
            return c;
        }
    }

    public class P3Test
    {
        private static int CreateRandom()
        {
            var r = new Random();
            var output = r.Next(0, 10);
            return output;
        }

        public static int GetRandomNumberTest()
        {
            return Data.RandomNumber;
        }

        public static string TryYourLuck(int input)
        {
            if (Data.Tries < Data.MaxTries)
            { 
            var a = IsCorrect(input);
            var b = GetReturnText(a);
            Data.Tries++;
            return b;
            }
            else
            {
                return "No More Tries";
            }

        }

        public static void Init()
        {
            Data.RandomNumber = CreateRandom();
            Data.Tries = 0;
        }

        private static bool IsCorrect(int a )
        {
            return a == Data.RandomNumber;
        }

        private static string GetReturnText(bool input)
        {
            var returnText = input ? "yes" : "no";
            return returnText;
        }
    }

    public class P4Test
    {
        public static int Input(string s)
        {
            var x = DeSpacer(s);
            var a = Cutter(x);
            var ret = a.Max();
            return ret;
        }

        private static string DeSpacer(string s)
        {
            var a = s.Replace(" ", "");
            return a;
        }

        private static int[] Cutter(string input)
        {
            var a =  input.Split(',');
            var b = Array.ConvertAll(a, int.Parse);
            return b;
        }
    }

    public class P5Test
    {
        public static int Faculty(int i)
        {
            var a = CreateSequence(i, i);
            var b = Multi(a);
            return b;
        }

        private static int Multi(int[] ints)
        {
            var a = ints[0];
            foreach (var inter in ints.Skip(1))
            {
                a = a * inter;
            }

            return a;
        }

        private static int[] CreateSequence(int i, int count)
        {
            var sequence = new int[count];

            for (var j = 0; j < count; j++)
            {
                sequence[j] = i - j;
            }

            return sequence;
        }
    }

    public static class Data
    {
        public static int RandomNumber;
        public static int Tries = 0;
        public static int MaxTries = 4;
    }

    public class Reader
    {

        public static string[] Readerer()
        {
            var a = ReadFile();
            var b = joiner(a);
            var c = Cutter(b);
            return c;
        }
        private static string[] ReadFile()
        {
            var text = System.IO.File.ReadAllLines(@"C:\Max\1.txt");
            return text;
        }

        private static string joiner(string[] input)
        {
            var a = string.Join(" ", input);
            return a;
        }

        private static string[] Cutter(string input)
        {
            var a = input.Split(' ');
            return a;
        }
    }
}

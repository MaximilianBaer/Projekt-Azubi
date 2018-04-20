using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todictionary;
using NUnit.Framework;

namespace test
{
    public class Test
    {
        [Test, Category("Funktionstest")]
        public void Test_1()
        {
            ToDictionary.eingabe("a=2");
            string ergebnis = ToDictionary.auslesen("a");
            Assert.AreEqual("2", ergebnis);
        }
        [Test, Category("Funktionstest")]
        public void Test_2()
        {
            ToDictionary.eingabe("g=8;h=2");
            string ergebnis = ToDictionary.auslesen("h");
            Assert.AreEqual("2", ergebnis);
        }
        [Test, Category("Funktionstest")]
        public void Test_3()
        {
            ToDictionary.eingabe("d=");
            string ergebnis = ToDictionary.auslesen("d");
            Assert.AreEqual("", ergebnis);
        }
        [Test, Category("Funktionstest")]
        public void Test_4()
        {
            ToDictionary.eingabe("=1");
            string ergebnis = ToDictionary.auslesen("");
            Assert.AreEqual("2", ergebnis);
        }
        [Test, Category("Funktionstest")]
        public void Test_5()
        {
            ToDictionary.eingabe("");
            string ergebnis = ToDictionary.auslesen("");
            Assert.AreEqual("", ergebnis);
        }
        [Test, Category("Funktionstest")]
        public void Test_6()
        {
            ToDictionary.eingabe("eggg==23");
            string ergebnis = ToDictionary.auslesen("eggg");
            Assert.AreEqual("=23", ergebnis);
        }
        [Test, Category("Funktionstest")]
        public void Test_7()
        {
            ToDictionary.eingabe("g=8;;h=2");
            string ergebnis = ToDictionary.auslesen("h");
            Assert.AreEqual("2", ergebnis);
        }
    }
}

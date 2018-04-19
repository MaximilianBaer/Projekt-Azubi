using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baeuernmultiplikator;
using NUnit.Framework;

namespace test
{
    [TestFixture]
    public class Test
    {
        [Test, Category("Funktionstest")]
        public void Test_1()
        {
            int zahl1 = 22, zahl2 = 222;
            int ergebnis = Bauernmultiplikator.Multipliziere(zahl1, zahl2);
            Assert.AreEqual(zahl1 * zahl2, ergebnis);
        }
        [Test, Category("Funktionstest")]
        public void Test_2()
        {
            int zahl1 = 22, zahl2 = 442;
            int ergebnis = Bauernmultiplikator.Multipliziere(zahl1, zahl2);
            Assert.AreEqual(zahl1 * zahl2, ergebnis);
        }
        [Test, Category("Funktionstest")]
        public void Test_3()
        {
            int zahl1 = 223, zahl2 = 223;
            int ergebnis = Bauernmultiplikator.Multipliziere(zahl1, zahl2);
            Assert.AreEqual(zahl1 * zahl2, ergebnis);
        }
    }
}

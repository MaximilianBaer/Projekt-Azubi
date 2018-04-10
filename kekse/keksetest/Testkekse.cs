using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kekse;
using NUnit.Framework;


namespace keksetest
{
    [TestFixture]
    public class Testkekse 
    {
        [Test, Category("Akzeptanstest")]
        public void Zahlen_zwichen_untergenze_obergrenze()
        {
            var ergebnis_1 = Kekse.Start_Zahlen_testen(3, 10);
            Assert.AreEqual(new[] { 3, 4, 5, 6, 7, 8, 9, 10 }, ergebnis_1.ToArray());
        }
        [Test, Category("Gerüsttest")]
        public void Anzahl_zahlen()
        {
            var ergebnis_2 = Kekse.Start_Zahlen_testen(-1, 45);
            Assert.AreEqual(47, ergebnis_2.Count());

        }
    }
}

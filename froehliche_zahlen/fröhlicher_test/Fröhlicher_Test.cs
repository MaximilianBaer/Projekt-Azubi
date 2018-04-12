using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using froehliche_zahlen;

namespace fröhlicher_test
{
    public class Fröhlicher_Test
    {
        [Test ,Category("Funktionstaest")]
        public void Fröhliche_zahl()
        {
            string Test_1 = Fröhliche_Zahlen.Zahleneingabe(180167660);
            Assert.AreEqual("Fröhliche Zahl", Test_1);

        }
        [Test, Category("Funktionstaest")]
        public void Traurige_zahl()
        {
            string Test_2 = Fröhliche_Zahlen.Zahleneingabe(1234567);
            Assert.AreEqual("Traugrige Zahl", Test_2);

        }
    }
}

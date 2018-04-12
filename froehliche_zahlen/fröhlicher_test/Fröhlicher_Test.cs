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
            string Test_1 = Fröhliche_Zahlen.Zahleneingabe(19);
            Assert.AreEqual("Fröhliche Zahl", Test_1);

        }
        [Test, Category("Funktionstaest")]
        public void Traurige_zahl()
        {
            string Test_1 = Fröhliche_Zahlen.Zahleneingabe(18000);
            Assert.AreEqual("Traugrige Zahl", Test_1);

        }
    }
}

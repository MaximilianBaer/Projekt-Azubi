﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using röhmiche_zahlen;
using NUnit.Framework;


namespace Test_Röhmiche_Zahlen
{
    public class Test_Rom
    {
        [Test, Category("Funktionstaest")]
        public void Test_1()
        {
            string Test_1 = Röhiche_Zahl.Eingabe(660);
            Assert.AreEqual("DCLX", Test_1);
        }
        [Test, Category("Funktionstaest")]
        public void Test_2()
        {
            string Test_1 = Röhiche_Zahl.Eingabe(2999);
            Assert.AreEqual("Zu Größ", Test_1);
        }
    }
}

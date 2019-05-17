using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hallo;
using NUnit.Framework;

namespace TEst
{
    [TestFixture]
    public class Testklasse1
    {
        [Test]
        public void TestenZahlen()
        {
            NumberLister de = new NumberLister();
            Assert.AreEqual("0,1,2", de.GetReturn("1,2,3,4,5,6,7,8,9,0"));
        }
        [Test]
        public void TestenFalschesFormat1()
        {
            
            NumberLister de = new NumberLister();
            Assert.AreEqual("wrong Format", de.GetReturn("4,5,6,7"));
        }

        [Test]
        public void TestenFalschesFormat2()
        {
            NumberLister de = new NumberLister();
            Assert.AreEqual("wrong Format", de.GetReturn("g4,5,6,7"));
        }

        [Test]
        public void TestenFalschesFormat3()
        {
            NumberLister de = new NumberLister();
            Assert.AreEqual("wrong Format", de.GetReturn(",5,6,7"));
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using uhrzeit;

namespace Test
{
    [TestFixture]
    public class Testclass3
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("ok", uhrzeit.Class3.checkOK("0:0"));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual("ok", uhrzeit.Class3.checkOK("23:59"));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual("Error", uhrzeit.Class3.checkOK("59:23"));
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual("Error", uhrzeit.Class3.checkOK(""));
        }
    }
}

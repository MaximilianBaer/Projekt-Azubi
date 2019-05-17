using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using nunit;
using NUnit.Framework.Internal;

namespace Teststs
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("yes", P1Test.Test1("5-6-7-8-9"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("yes", P1Test.Test1("20-19-18-17-16"));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual("no", P1Test.Test1("20-19-1-17-16"));
        }

    }

    public class Class2
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(38, P2Test.Test2());
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("fhasgkdjfhskgadfhgaksjdhbfhdsb", P2Test.Test3());
        }
    }

    public class Class3
    {
        [Test]
        public void Test1()
        {
            P3Test.Init();
            var a = P3Test.GetRandomNumberTest();
            Assert.AreEqual("yes", P3Test.TryYourLuck(a));
        }

        [Test]
        public void Test2()
        {
            P3Test.Init();
            var a = P3Test.GetRandomNumberTest();
            Assert.AreEqual("no", P3Test.TryYourLuck(a+1));
        }

        [Test]
        public void Test3()
        {
            P3Test.Init();
            var a = P3Test.GetRandomNumberTest();
            Assert.AreEqual("no", P3Test.TryYourLuck(a + 1));
            Assert.AreEqual("no", P3Test.TryYourLuck(a + 1));
            Assert.AreEqual("no", P3Test.TryYourLuck(a + 1));
            Assert.AreEqual("no", P3Test.TryYourLuck(a + 1));
            //Assert.AreEqual("no", P3Test.TryYourLuck(a + 1));
            Assert.AreEqual("No More Tries", P3Test.TryYourLuck(a + 1));
        }
    }

    public class Class4
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(66, P4Test.Input("9, 12, 2, 66, 3, 7, 41"));
        }
    }

    public class Class5
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(120, actual: P5Test.Faculty(5));
        }
    }
} 

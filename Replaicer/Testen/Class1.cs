using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Replaicer;

namespace Testen
{
    [TestFixture]
    public class test2
    {
        [Test]
        public void test1()
        {
            Assert.AreEqual(6, VowelMutationCounter.UmlautsCounter("unuebersichtlich"));
        }
    }
}

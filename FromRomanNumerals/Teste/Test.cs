using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace Teste
{
    public class Test
    {
        [Test]
        public void TEST1()
        {
            Assert.AreEqual(2, 1+1);
        }
    }
}

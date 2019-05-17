using NUnit.Framework;
using LIFO;

namespace TestLib
{
    [TestFixture]
    public class Test
    {
        [Test]
        public static void PushAndCount()
        {
            var testStapel = new Stacks<int>();
            testStapel.Push(1);
            testStapel.Push(5);
            testStapel.Push(12);
            testStapel.Push(4);
            Assert.AreEqual(4, testStapel.Count);
        }

        [Test]
        public static void PopAndCount()
        {
            var testStapel = new Stacks<int>();
            testStapel.Push(1);
            testStapel.Push(5);
            testStapel.Push(12);
            testStapel.Push(4);
            Assert.AreEqual(4, testStapel.Count);
            testStapel.Pop();
            testStapel.Pop();
            Assert.AreEqual(2, testStapel.Count);
        }

        [Test]
        public static void PeekTopElement()
        {
            var testStapel = new Stacks<int>();
            testStapel.Push(1);
            testStapel.Push(5);
            testStapel.Push(12);
            testStapel.Push(4);
            Assert.AreEqual(4, testStapel.Count);
            Assert.AreEqual(4, testStapel.Peek());
            testStapel.Pop();
            Assert.AreEqual(3, testStapel.Count);
            Assert.AreEqual(12, testStapel.Peek());
            testStapel.Pop();
            Assert.AreEqual(2, testStapel.Count);
            Assert.AreEqual(5, testStapel.Peek());
            testStapel.Pop();
            Assert.AreEqual(1, testStapel.Count);
            Assert.AreEqual(1, testStapel.Peek());
            testStapel.Pop();
            Assert.AreEqual(0, testStapel.Count);
        }
    }
}
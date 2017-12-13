using System;
using NUnit.Framework;
using Apples;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Apple red = new Apple();

            Assert.AreEqual("apple", red.GetApple());
        }

        [Test]
        public void Tester()
        {
            Apple red = new Apple();

            Assert.AreEqual("ale", red.GetApple());
        }
    }
}

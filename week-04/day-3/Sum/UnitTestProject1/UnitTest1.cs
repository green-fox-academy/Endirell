using System;
using NUnit.Framework;
using Sum;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        
        [Test]
        public void TestMethod1()
        {
            List<int> people = new List<int>();
            people.Add(6);
            people.Add(7);
            people.Add(7);
            people.Add(7);
            people.Add(1);

            Assert.AreEqual(28, people.Sum());

        }

        [Test]
        public void TestMethod2()
        {
            List<int> people = new List<int>();
           
            Assert.AreEqual(0, people.Sum());

        }

        [Test]
        public void TestMethod3()
        {
            List<int> people = new List<int>();
            people.Add(6);
            
            Assert.AreEqual(6, people.Sum());

        }

        [Test]
        public void TestMethod4()
        {
            List<int> people = new List<int>();
            people.Add(6);
            people.Add(7);
            people.Add(7);
            

            Assert.AreEqual(20, people.Sum());

        }

        [Test]
        public void TestMethod5()
        {
            List<int> people = new List<int>();

            people = null;
            
            Assert.AreEqual(null, people.Sum());

        }
    }
}

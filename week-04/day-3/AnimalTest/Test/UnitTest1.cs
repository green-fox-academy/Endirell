using System;
using NUnit.Framework;
using Animal;


namespace Test
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Hunger()
        {
            var troll = new Animal.Animals();

            Assert.AreEqual(50, troll.hunger);
            
        }

        [Test]
        public void Thirst()
        {
            var troll = new Animal.Animals();
            
            Assert.AreEqual(50, troll.thirst);
        }

        [Test]
        public void Testeat()
        {
            var troll = new Animal.Animals();

            troll.Eat();

            Assert.AreEqual(49, troll.hunger);
        }

        [Test]
        public void Testdrink()
        {
            var troll = new Animal.Animals();

            troll.Drink();

            Assert.AreEqual(49, troll.thirst);
        }

        [Test]
        public void Testplay()
        {
            var troll = new Animal.Animals();
                 
            troll.Play();

            Assert.AreEqual(51, troll.hunger);
            Assert.AreEqual(51, troll.thirst);

        }
    }
}

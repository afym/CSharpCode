using System;
using NUnit.Framework;

namespace CSharpCode.OOP
{
    [TestFixture]
    class ZooTest
    {
        [Test]
        public void ZooAnimalTest() 
        {
            LandAnimal tiger = new LandAnimal();
            tiger.Name = "Tiger";

            Assert.IsTrue(tiger.CanRun());
            Assert.IsTrue(!tiger.CanFly());
            Assert.IsTrue(!tiger.CanSwim());
            Assert.AreEqual(tiger.Type.Code, 'L');
        }
    }
}

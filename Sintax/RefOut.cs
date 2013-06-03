using System;
using NUnit.Framework;

namespace CSharpCode.Sintax
{
    [TestFixture]
    class RefOut
    {
        [Test]
        public void RefTest()
        {
            // ref requires that the variable be initialized
            int value = 10;

            Assert.IsFalse(value == 11);

            // reference variable ( + 1)
            IncrementByOne(ref value);
            Assert.IsTrue(value == 11);

            // increment by 3
            for (int i = 0; i < 3; i++)
            {
                IncrementByOne(ref value);
            }

            Assert.IsTrue(value == 14);
        }

        [Test]
        public void OutTest()
        {
            // the variable dont need to be initialized
            int value; 
            SomeOperations(out value, 3);
            Assert.IsTrue(value == 3);
        }

        public void IncrementByOne(ref int value)
        {
            value += 1;
        }

        public void SomeOperations(out int value, int increment)
        {
            value = 0;

            value += increment;
        }
    }
}

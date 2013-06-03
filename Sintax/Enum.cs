using System;
using NUnit.Framework;

namespace CSharpCode.Sintax
{
    [TestFixture]
    class Enum
    {
        enum Days { Monday, Sunday, Friday}
        enum Codes :long { Max = 2147483648L, Min = 255L};

        [Test]
        public void EnumTest() 
        {
            Assert.AreEqual((int) Days.Monday, 0);
            Assert.AreEqual((int) Days.Sunday, 1);
            Assert.AreEqual((int) Days.Friday, 2);
        }
    }
}

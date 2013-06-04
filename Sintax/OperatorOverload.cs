using System;
using NUnit.Framework;

namespace CSharpCode.Sintax
{
    [TestFixture]
    class OperatorOverload
    {
        [Test]
        public void OperatorTest() 
        {
            Complex c1 = new Complex(1, 4);
            Complex c2 = new Complex(-1, -4);

            Complex c3 = c1 + c2;

            Assert.AreEqual(c3.GetModule(), 0);
        }
    }

    class Complex 
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Complex(int x, int y) 
        {
            this.X = x;
            this.Y = y;
        }

        public double GetModule()
        {
            double baseNum = Math.Pow(this.X, 2) + Math.Pow(this.Y, 2);

            return Math.Pow(baseNum, 0.5);
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.X + c2.X, c1.Y + c2.Y);
        }
    }
}

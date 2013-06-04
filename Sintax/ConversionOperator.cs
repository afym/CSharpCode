using System;
using NUnit.Framework;

namespace CSharpCode.Sintax
{
    [TestFixture]
    class ConversionOperator
    {
        [Test]
        public void ConvertPriceTest()
        {
            double cost = 100.10;
            Assert.That(cost, Is.InstanceOf<double>());

            Price price = (Price)cost;
            Assert.That(price, Is.InstanceOf<Price>());
        }
    }

    public class Price 
    {
        public double value { set; get; }

        public double GetIgv() 
        {
            return this.value * 0.19;
        }
    
        public static implicit operator Price(double price)
        {
            Price p = new Price();
            p.value = price;

            return p;
        } 
    }
}

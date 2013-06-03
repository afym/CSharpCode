using System;
using NUnit.Framework;

namespace CSharpCode.Sintax
{
    // declaring delegate
    public delegate string GetOutPut(int number);

    [TestFixture]
    class Delegate
    {
        [Test]
        public void NumbersTest() 
        {
            // My class
            Numbers numbers = new Numbers();
            // My delegates
            GetOutPut g1 = new GetOutPut(numbers.GetTypeNumberInSymbol);
            GetOutPut g2 = new GetOutPut(numbers.GetTypeNumberInWords);

            // Testing my gelegates
            Assert.AreEqual(g1(5), "+");
            Assert.AreEqual(g1(-10), "-");
            Assert.AreEqual(g2(0), "Zero");
        }
    }

    public class Numbers 
    {
         // first method
        public string GetTypeNumberInWords(int number)
        {
            if (number > 0)
            {
                return "Positive";
            }

            if (number < 0)
            {
                return "Negative";
            }

            return "Zero";
        }

        // second method
        public string GetTypeNumberInSymbol(int number)
        {
            if (number > 0)
            {
                return "+";
            }

            if (number < 0)
            {
                return "-";
            }

            return "0";
        }    
    } 
}

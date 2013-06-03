using System;
using NUnit.Framework;

namespace CSharpCode.Sintax
{
    [TestFixture]
    class Indexers
    {
        [Test]
        public void IndexerTest() 
        {
            AnimalColletion<string> animals = new AnimalColletion<string>();
            
            for (int i = 0; i < 99; i++) 
            {
                animals[i] = "Animal # " + i;
            }

            Assert.AreEqual(animals[55], "Animal # 55");
        }
    }

    // Animal Indexer Collection
    public class AnimalColletion<T>
    {
        private string[] animals = new string[100];

        public string this[int index]
        {
            get 
            {
                return animals[index];
            }

            set 
            {
                animals[index] = value;
            }
        }
    }
}

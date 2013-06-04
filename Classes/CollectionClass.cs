using System;
using System.Collections;
using System.Collections.Generic;
using CSharpCode.OOP;
using NUnit.Framework;

namespace CSharpCode.Classes
{
    [TestFixture]
    class CollectionClass
    {
        [Test]
        public void LandAnimalList() 
        {
            LandAnimalList animals = new LandAnimalList();
            animals.Add(new LandAnimal { Name = "Lion"});
            animals.Add(new LandAnimal { Name = "Tiger" });

            Assert.AreEqual(animals[0].Name, "Lion");
        }

        [Test]
        public void ListGenericTest() 
        {
            LandAnimal l1 = new LandAnimal() { Name = "Lion" };
            LandAnimal l2 = new LandAnimal() { Name = "Tiger" };
            LandAnimal l3 = new LandAnimal() { Name = "Puma" };

            List<LandAnimal> animals = new List<LandAnimal>();
            animals.Add(l1);
            animals.Add(l2);
            animals.Add(l3);

            Assert.IsTrue(animals[2].CanRun());
        }

        [Test]
        public void DictionaryGenericTest() 
        {
            LandAnimal l1 = new LandAnimal() { Name = "Lion" };
            LandAnimal l2 = new LandAnimal() { Name = "Tiger" };
            LandAnimal l3 = new LandAnimal() { Name = "Puma" };

            Dictionary<string, LandAnimal> animals = new Dictionary<string, LandAnimal>();
            animals.Add("Lion", l1);
            animals.Add("Tiger", l1);
            animals.Add("Puma", l1);

            Assert.AreEqual(animals["Lion"].Name, "Lion");
        }
    }
}

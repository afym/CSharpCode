using System;
using System.Collections;
using CSharpCode.OOP;

namespace CSharpCode.Classes
{
    class LandAnimalList : ArrayList
    {
        public int Add(LandAnimal s)
        {
            return base.Add(s);
        }

        public LandAnimal this[int index]
        {
            set { base[index] = value; }
            get { return base[index] as LandAnimal; }
        }
    }
}

using System;
using System.Collections;

namespace CSharpCode.OOP
{
    class LandAnimalList : ArrayList
    {
        public int Add(Classes.Student s) 
        {
            return base.Add(s);
        }

        public Classes.Student this[int index] 
        {
            set { base[index] = value; }
            get { return base[index] as Classes.Student;}
        }
    }
}

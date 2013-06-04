using System;

namespace CSharpCode.OOP
{
    abstract class Animal
    {
        public int Id { set; get;}
        public string Name { set; get;}
        public AnimalType Type { set;  get; }

        public abstract bool CanRun();
        public abstract bool CanFly();
        public abstract bool CanSwim();
    }
}

using System;

namespace CSharpCode.OOP
{
    abstract class Animal
    {
        public int Id { set; get;}
        public string Name { set; get;}
        public AnimalType Type { set;  get; }

        public abstract string Run();
        public abstract string Fly();
        public abstract string Swim();
    }
}

using System;

namespace CSharpCode.OOP
{
    class LandAnimal : Animal, IAnimal
    {
        public LandAnimal()
        {
            AnimalType type = new AnimalType();
            type.Code = type.getTypeCode(EAnimalTypes.Land);
        }

        public string getDescription() 
        {
            return "";
        }

        public override string Run() { return ""; }
        public override string Fly() { return ""; }
        public override string Swim() { return ""; }
        
    }
}

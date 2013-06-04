using System;

namespace CSharpCode.OOP
{
    class LandAnimal : Animal, IAnimal
    {
        public LandAnimal()
        {
            AnimalType type = new AnimalType();
            type.Name = "Land";
            type.Code = type.getTypeCode(EAnimalTypes.Land);

            this.Name = "Empty";
            this.Type = type;
        }

        public string getDescription() 
        {
            return "I am a " + this.Name;
        }

        public override bool CanRun()
        {
            if(this.Type.Code == 'L') 
            {
                return true;
            }

            return false; 
        }

        public override bool CanFly() 
        {
            if (this.Type.Code  == 'F') {
                return true;
            }

            return false;
        }

        public override bool CanSwim()
        { 
            if(this.Type.Code == 'S')
            {
                return true;
            }

            return false;
        }
    }
}

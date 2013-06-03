using System;

namespace CSharpCode.OOP
{
    enum EAnimalTypes{Land, Sea, Fly}

    class AnimalType
    {
        public int Id { set; get; }
        public char Code { set; get; }
        public string Name { set; get; }

        public char getTypeCode(EAnimalTypes type)
        {
            switch((int) type)
            {
                case 0:
                    return 'L';
                case 1:
                    return 'S';
                case 2:
                    return 'F';
            }

            return '0';
        }
    }
}

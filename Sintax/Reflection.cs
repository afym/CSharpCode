using System;

namespace CSharpCode.Sintax
{
    class Reflection
    {
        public static void GetOnConsole() 
        {
            Soldier s1 = new Soldier();

            Type type = s1.GetType();

            var members = type.GetMembers();

            foreach(var member in members)
            {
                Console.WriteLine(member.Name);
            }
        }
    }

    public class Soldier 
    {
        public string name { set; get; }
        public string surname { set; get; }

        public void attack() { }

        public string WarShout() 
        {
            return "A!!!";
        }
    }
}

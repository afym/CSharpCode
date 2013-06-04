using System.Reflection;
using System;

namespace CSharpCode.Classes
{
    class AssemblyClass
    {
        public static void GetInstaceOfSomeObject() 
        {
            foreach(Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.GetInterface("IMessages") != null)
                {
                    Console.WriteLine("I get Interface IMessages");
                }
            }
        }
    }

    public interface IMessages 
    {
        string getAlertMessage();
    }

    public class ResponseClient : IMessages 
    {
        public string getAlertMessage() 
        {
            return "Alert!!!!";
        }
    }
}

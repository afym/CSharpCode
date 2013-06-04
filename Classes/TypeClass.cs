using System;
using System.Reflection;

namespace CSharpCode.Classes
{
    class TypeClass
    {
        public static string PrintMessage() 
        {
            MethodInfo info = typeof(TimeTime).GetMethod("Today");
            TimeTime t = new TimeTime();
            string result = (string)info.Invoke(t, null);

            return result;
        }
    }

    public class TimeTime 
    {
        public string Today() 
        {
            return DateTime.Now.ToString();
        }
    }
}

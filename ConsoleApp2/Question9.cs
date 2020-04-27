using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Question9
    {
        public static void ReflectDemo()
        {
            Assembly assembly = Assembly.LoadFrom("ClassLibrary1.dll");
            Type type = assembly.GetType("ClassLibrary1.Person");
            if(type != null)
            {
                object obj = Activator.CreateInstance(type);
                PropertyInfo pi = type.GetProperty("Name");
                if(pi != null && pi.CanWrite)
                {
                    pi.SetValue(obj, "张三");
                }
                MethodInfo mi = type.GetMethod("SayHello", BindingFlags.NonPublic | BindingFlags.Instance);
                if(mi != null)
                {
                    mi.Invoke(obj, null);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Question7
    {
        public static void StringSort()
        {
            List<string> lst =new List<string> { "abcd", null, "bc", "hello", "x", "123" };
            lst.Sort(new StringComparer());
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
        }

        public class StringComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return (x?.Length ?? -1) - (y?.Length ?? -1);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Question14
    {
        public static void GetAndReplaceEmail()
        {
            string str = "fadjsldfs abcd@example.com fal13342 你好@helloworld.cn";
            Regex regex = new Regex(@"(\w+)@(\w+\.\w+)");
            MatchCollection mc = regex.Matches(str);
            foreach (Match item in mc)
            {
                Console.WriteLine(item.Value);
            }

            //string strReplace = regex.Replace(str, (e) => {
            //    return "*".PadRight(e.Groups[1].Length, '*') + "@" + e.Groups[2].Value;
            //});

            string strReplace = regex.Replace(str, (e) => "*".PadRight(e.Groups[1].Length, '*') + "@" + e.Groups[2].Value);
            Console.WriteLine("替换后:");
            Console.WriteLine(strReplace);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class Question5
    {
        public static void CheckMobile()
        {
            string str1 = "13211111111";
            Console.WriteLine($"{str1} is mobile:{str1.IsMobile()}");

            string str2 = "1321111111";
            Console.WriteLine($"{str2} is mobile:{str2.IsMobile()}");

            string str3 = "1ac11111111";
            Console.WriteLine($"{str3} is mobile:{str3.IsMobile()}");
        }

        private static bool IsMobile(this string str)
        {
            return Regex.IsMatch(str, @"^1\d{10}$");
        }
    }
}

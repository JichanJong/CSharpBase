using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Question6
    {
        public static void GetNoRepeat()
        {
            int[] arrNum = { 10, 22, 11, 22, 3, 10, 5, 9 };
            HashSet<int> set = new HashSet<int>();
            foreach (var item in arrNum)
            {
                set.Add(item);
            }
            foreach (var item in set)
            {
                Console.Write(item + " ");
            }
        }

    }
}

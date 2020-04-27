using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Question1
    {
        public static void CalcPageCount()
        {
            int pageSize;
            int recordCount;
            Console.WriteLine("请输入每页条数");
            while (!int.TryParse(Console.ReadLine(),out pageSize) || pageSize == 0) 
            {
                Console.WriteLine("输入的不是整数或者为0，请重新输入");
            }
            Console.WriteLine("请输入总记录数");
            while (!int.TryParse(Console.ReadLine(),out recordCount))
            {
                Console.WriteLine("输入的不是整数，请重新输入");
            }

            int pageCount = (int)Math.Ceiling(recordCount * 1.0m / pageSize);
            Console.WriteLine("总页数为：" + pageCount);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Question2
    {
        public static void BubbleSort()
        {
            int[] arrNum = { 20, 99, 56, 51, 67, 39 };
            Console.WriteLine("排序前：");
            foreach (var item in arrNum)
            {
                Console.Write(item + " ");
            }
            for (int i = 1; i < arrNum.Length; i++)
            {
                for (int j = 0; j < arrNum.Length-i; j++)
                {
                    if (arrNum[j] > arrNum[j + 1]) 
                    {
                        int temp = arrNum[j];
                        arrNum[j] = arrNum[j + 1];
                        arrNum[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\r\n排序后：");
            foreach (var item in arrNum)
            {
                Console.Write(item + " ");
            }
        }
    }
}

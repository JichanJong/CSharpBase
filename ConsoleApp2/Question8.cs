using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Question8
    {
        public static void CheckCanPay()
        {
            Car c = new Car
            {
                Balance = 100000
            };
            bool result1 = c.CanPay(() => 200000);
            Console.WriteLine(result1);

            Car c2 = new Car
            {
                Balance = 100000
            };
            bool result2 = c2.CanPay(() => 89000);
            Console.WriteLine(result2);
        }
    }
    public class Car
    {
        public decimal Balance { get; set; }

        public bool CanPay(Func<decimal> func)
        {
            if(func != null)
            {
                return Balance - func() >= 0;
            }
            return false;
        }
    }
}

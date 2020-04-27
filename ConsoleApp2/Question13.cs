using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Question13
    {
        public static void JsonSerialize()
        {
            List<Student> lst = new List<Student> 
            { 
                new Student{ Name = "张三", Age = 20, Height = 175},
                new Student{ Name = "李四", Age = 21, Height = 180},
                new Student{ Name = "露西", Age = 18, Height = 160}
            };

            Console.WriteLine(JsonConvert.SerializeObject(lst));
        }
    }
}

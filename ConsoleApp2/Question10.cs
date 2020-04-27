using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Question10
    {
        public static void DeepCopy()
        {
            Student student = new Student
            {
                Name = "张三",
                Age = 20,
                Height = 180
            };
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                formatter.Serialize(ms, student);
                ms.Position = 0;
                Student studentCopy = formatter.Deserialize(ms) as Student;
                //Student studentCopy = student;
                if (studentCopy != null)
                {
                    studentCopy.Name = "李四";
                    Console.WriteLine(student.Name);
                }
            }
            //其它方式可以使用反射、Json等实现
        }
    }
    [Serializable]
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Question3
    {
        public static void PrintShape()
        {
            Rectangle rectangle = new Rectangle
            {
                Name = "长方形",
                Length = 20,
                Width = 10
            };

            Circle circle = new Circle(3)
            {
                Name = "圆"
            };
            Shape shape1 = rectangle;
            Shape shape2 = circle;
            Console.WriteLine($"{shape1.Name}的面积是：{shape1.CalcArea()}");
            Console.WriteLine($"{shape2.Name}的面积是：{shape2.CalcArea()}");
            Console.WriteLine(shape1);//shape1.Name
            Console.WriteLine(shape2);//shape2.Name
        }
    }

    public abstract class Shape
    {
        public abstract string Name { get; set; }

        public abstract decimal CalcArea();

        public override string ToString()
        {
            return Name;
        }
    }

    public class Rectangle : Shape
    {
        private string _name;
        public override string Name { get => _name; set => _name = value; }

        public decimal Length { get; set; }

        public decimal Width { get; set; }
        public override decimal CalcArea()
        {
            return Length * Width;
        }
    }

    public class Circle : Shape
    {
        private string _name;
        public override string Name { get => _name; set => _name = value; }

        public decimal Radius { get; private set; }
        public Circle(decimal radius)
        {
            Radius = radius;
        }
        public override decimal CalcArea()
        {
            return (decimal)Math.PI * Radius * Radius;
        }
    }
}

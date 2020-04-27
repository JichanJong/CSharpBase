using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace ConsoleApp2
{
    public class Question12
    {
        public static void XmlOperate()
        {
            string xmlFile = "test.xml";

            ////方式一
            //XmlDocument doc = new XmlDocument();
            //doc.Load(xmlFile);

            //XmlNodeList nodeList = doc.SelectNodes("/packages/package");
            //List<XmlNode> nodes40 = new List<XmlNode>();
            //List<XmlNode> nodes45 = new List<XmlNode>();
            //List<XmlNode> nodes46 = new List<XmlNode>();
            //foreach (XmlNode item in nodeList)
            //{
            //    if (item.Attributes["targetFramework"]?.Value == "net46")
            //    {
            //        nodes46.Add(item);
            //    }
            //    if (item.Attributes["targetFramework"]?.Value == "net45")
            //    {
            //        nodes45.Add(item);
            //    }
            //    if (item.Attributes["targetFramework"]?.Value == "net40")
            //    {
            //        nodes40.Add(item);
            //    }
            //}
            //Console.WriteLine("net framework 4.0");
            //foreach (var item in nodes40)
            //{
            //    Console.WriteLine(item.Attributes["id"]?.Value);
            //}

            //Console.WriteLine("\r\nnet framework 4.5");
            //foreach (var item in nodes45)
            //{
            //    Console.WriteLine(item.Attributes["id"]?.Value);
            //}

            //Console.WriteLine("\r\nnet framework 4.6");
            //foreach (var item in nodes46)
            //{
            //    Console.WriteLine(item.Attributes["id"]?.Value);
            //}

            ////方式二 Xpath 表达式，属性=值 过滤
            //Console.WriteLine("net framework 4.0");
            //XmlNodeList nodes40 = doc.SelectNodes("/packages/package[@targetFramework=\"net40\"]");
            //foreach (XmlNode item in nodes40)
            //{
            //    Console.WriteLine(item.Attributes["id"]?.Value);
            //}
            //XmlNodeList nodes45 = doc.SelectNodes("/packages/package[@targetFramework=\"net45\"]");
            //Console.WriteLine("\r\nnet framework 4.5");
            //foreach (XmlNode item in nodes45)
            //{
            //    Console.WriteLine(item.Attributes["id"]?.Value);
            //}
            //XmlNodeList nodes46 = doc.SelectNodes("/packages/package[@targetFramework=\"net46\"]");
            //Console.WriteLine("\r\nnet framework 4.6");
            //foreach (XmlNode item in nodes46)
            //{
            //    Console.WriteLine(item.Attributes["id"]?.Value);
            //}

            //方式三
            XDocument document = XDocument.Load(xmlFile);
            XElement root = document.Root;

            Console.WriteLine("net framework 4.0");
            var nodes40 = root.XPathSelectElements("package[@targetFramework=\"net40\"]");
            foreach (XElement item in nodes40)
            {
                Console.WriteLine(item.Attribute("id").Value);
            }

            Console.WriteLine("\r\nnet framework 4.5");
            var nodes45 = root.XPathSelectElements("package[@targetFramework=\"net45\"]");
            foreach (XElement item in nodes45)
            {
                Console.WriteLine(item.Attribute("id").Value);
            }

            Console.WriteLine("\r\nnet framework 4.6");
            var nodes46 = root.XPathSelectElements("package[@targetFramework=\"net46\"]");
            foreach (XElement item in nodes46)
            {
                Console.WriteLine(item.Attribute("id").Value);
            }
        }
    }
}

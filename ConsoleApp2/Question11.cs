using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Question11
    {
        public static void CopyFile()
        {
            string sourceFile = @"C:\电影\栋笃特工.BD.720p.国粤双语中字.mkv";
            string destFile = @"C:\电影\1.mkv";
            using (FileStream fsRead = new FileStream(sourceFile,FileMode.Open,FileAccess.Read),fsWrite = new FileStream(destFile,FileMode.OpenOrCreate,FileAccess.Write))
            {
                int buffer = 4 * 1024 * 1024;
                byte[] bytes = new byte[buffer];
                int length = fsRead.Read(bytes, 0, buffer);
                long fileLength = fsRead.Length;
                long sumReadLength = 0;
                while(length > 0)
                {
                    sumReadLength += length;
                    fsWrite.Write(bytes, 0, length);
                    Console.WriteLine($"已完成：{(int)(sumReadLength * 1.0m / fileLength * 100)}%");
                    length = fsRead.Read(bytes, 0, buffer);
                }
                Console.WriteLine("拷贝完成");
            }
        }
    }
}

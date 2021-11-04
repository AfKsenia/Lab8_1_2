using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Lab8_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathdir = "D:/Games";
            DirectoryInfo direct = new DirectoryInfo(pathdir);
            if (direct.Exists)
            {
                foreach (DirectoryInfo item in direct.GetDirectories())
                {
                    Console.WriteLine();
                    Console.WriteLine("Содержимое каталога \"{0}\"", item.Name);
                    Console.WriteLine();
                    foreach (DirectoryInfo unit in item.GetDirectories())
                    {
                        Console.WriteLine (unit.Name);
                    }
                }
            }   
           Console.ReadKey();
        }
    }
}

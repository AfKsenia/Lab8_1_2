using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Logs2";
            DirectoryInfo dir = new DirectoryInfo(path);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                File.Create(path);

            }
            string path2 = "Logs2/Log.txt";
            if (!File.Exists(path2))
            {
                File.Create(path2);
            }

            using (StreamWriter sw = new StreamWriter(path2))
            {
                const int n = 10;
                int[] array = new int[n];
                Random random = new Random();
                for (int i = 0; i < n; i++)
                {
                    array[i] = random.Next(0, 10);
                    sw.Write("{0} ",array[i]);
                }
            }
            using (StreamReader sr = new StreamReader(path2))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            using (StreamReader sr = new StreamReader(path2))
            {

                string[] numbs = sr.ReadToEnd().Split(' ');
                int Sum = 0;

                for (int i = 0; i < numbs.Length-1; ++i)
                {
                    Sum += Convert.ToInt32(numbs[i].ToString());
                }
                Console.WriteLine(sr.ReadToEnd());
                Console.WriteLine("Сумма случаных чисел {0}", Sum);

            }
            Console.ReadKey();
        }
    }
}

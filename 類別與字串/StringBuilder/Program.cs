using System;
using System.Diagnostics;
using System.Text;

namespace StringBuilderEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder 沒有開闢空間，大量資料推薦使用
            StringBuilder sb = new StringBuilder();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 100000; i++)
            {
                sb.Append(i);
            }
            sw.Stop();
            System.Console.WriteLine(sb.ToString());
            Console.WriteLine(sw.Elapsed);
        }
    }
}

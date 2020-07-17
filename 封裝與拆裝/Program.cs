using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Box
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            object o = n;//裝箱
            int nn = (int)o; //拆箱


            //封裝100000000次
            ArrayList arrlist = new ArrayList();
            //00:00:05.9914171
            List<int> list = new List<int>();
            //00:00:00.6070579
   
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 100000000; i++)
            {
                list.Add(1);
            }
            sw.Stop();
            System.Console.WriteLine(sw.Elapsed);

        }
    }
}

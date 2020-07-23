using System;
using System.Threading;


namespace 前台後台線程
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Thread worker = new Thread(() => Console.ReadLine());
            if (args.Length > 0)
            {
                worker.IsBackground=true;
            }
            worker.Start();
        }
    }
}

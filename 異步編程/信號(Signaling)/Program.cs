using System;
using System.Threading;

namespace 信號_Signaling_
{
    class Program
    {
        static void Main(string[] args)
        {
            var signal = new ManualResetEvent(false);
            new Thread(() =>
            {
                System.Console.WriteLine("Waiting for signal");
                signal.WaitOne();
                signal.Dispose();
                System.Console.WriteLine("Got singal!");
            }).Start();

            Thread.Sleep(5000);
            signal.Set();//打開信號

        }
    }
}

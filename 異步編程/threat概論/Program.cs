using System;
using System.Threading;

namespace threat
{

    class Program
    {
        static Thread thread1, thread2;
        static void Main(string[] args)
        {

            thread1 = new Thread(ThreadProc);
            thread1.Name = "Thread1";
            thread1.Start();

            thread2 = new Thread(ThreadProc);
            thread2.Name = "Thread2";
            thread2.Start();





            // //Join() : 可以等待另一線程結束
            // Thread th1 = new Thread(Test);
            // th1.Start();
            // th1.Join(); //主線程等待th1結束後才執行write
            // System.Console.WriteLine("Th1 end");

            // Thread th2 = new Thread(Test2);
            // th2.Start();//主線程執行後才執行th2
            // System.Console.WriteLine("Th2 end");

        }


        //Shared共享:多個線程都引用到同一個對象實例，就共享數據
        //盡量避免共享
        class ThreadTest
        {
            bool _done;

            static void Main()
            {
                //由於兩線程再同一個 Class實例上調用Go().所以他們共享_done
                //結果打印一個Done
                ThreadTest tt = new ThreadTest(); //創建共同實例
                new Thread(tt.Go).Start(); //線程執行
                tt.Go();//主線程執行



                // ThreadStart action = () =>
                // {
                //     if (!done)
                //     {
                //         done = true;
                //         System.Console.WriteLine("Done");
                //     }
                // };

            }
            void Go()
            {
                if (!_done)
                {
                    _done = true;
                    System.Console.WriteLine("Done");
                }
            }
        }


        public static void ThreadProc()
        {
            System.Console.WriteLine("\n thread:{0}", Thread.CurrentThread.Name);
            if (Thread.CurrentThread.Name == "Thread1" &&
                thread2.ThreadState != ThreadState.Unstarted)
                if (thread2.Join(2000))//假如2秒後沒執行完成
                    System.Console.WriteLine("Thread2 has termminated.");
                else
                    System.Console.WriteLine("The timeout has elapsed and Thread1 will resume");

            Thread.Sleep(4000);
            System.Console.WriteLine("\nCurrent thread {0}", Thread.CurrentThread.Name);
            System.Console.WriteLine("Thread1: {0}", thread1.ThreadState);
            System.Console.WriteLine("Thread2: {0}", thread2.ThreadState);
        }

        private static void Test()
        {

            for (int i = 0; i < 100; i++)
            {
                System.Console.Write(i);
            }
        }
        private static void Test2()
        {

            for (int i = 0; i < 100; i++)
            {
                System.Console.Write("i");
            }
        }
    }
}

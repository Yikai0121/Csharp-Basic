using System;
using System.Threading;

namespace 線程
{
    class Program
    {
        static void Main(string[] args)
        {
            //前台線程:只有所有的前台線程都關閉才能完成程序關閉
            //後台線程:只有所有前台線程結束，後台線程自動結束
            //創建一個線程去執行這個方法
            //一開始件至都是前台線程
            Thread th = new Thread(Test);
            //設置為後臺線程
            th.IsBackground = true;
            th.Start();


            //方法有參數
            //方法必須傳參數為object
            //並在.start(object)放入參數
            Thread th2 = new Thread(Test2);
            th2.IsBackground = true;
            th2.Start("123");


        }
        private static void Test()
        {
            for (int i = 0; i < 10000; i++)
            {
                System.Console.WriteLine(i);
            }
        }
        private static void Test2(object s)
        {
            //方法內可以轉換類型
            string ss = (string)s;
            for (int i = 0; i < 10000; i++)
            {
                System.Console.WriteLine(i);
            }
        }
    }

}

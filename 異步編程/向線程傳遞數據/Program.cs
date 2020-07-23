using System;
using System.Threading;

namespace 向線程傳遞數據
{
    class Program
    {
        static void Main(string[] args)
        {
            // //非lambda =>方法參數必須為object
            // Thread tt = new Thread(Print);
            // tt.Start("Hello");

            // //1.傳遞數據
            // Thread t = new Thread(() => Test("Hello"));
            // t.Start();

            // //2.傳遞數據:邏輯直接放在lambda裡面
            // new Thread(() =>
            // {
            //     System.Console.WriteLine("Hello");
            //     System.Console.WriteLine("Ya");
            // });


            //可能輸出會是重複的數值
            //i循環只向同一內存
            //每個線程對console調用都會進行修改
            for (int i = 0; i < 10; i++)
            {
                new Thread(() => System.Console.WriteLine(i)).Start();
            }

            //修補辦法
            //但順序仍無法保證
            for (int i = 0; i < 10; i++)
            {
                int temp = i;
                new Thread(() => System.Console.WriteLine(i)).Start();
            }



        }
        public static void Test(string Message)
        {
            System.Console.WriteLine(Message);
        }
        public static void Print(object n)
        {
            string str = (string)n;//必須
            System.Console.WriteLine(str);
        }

    }
}

using System;
using System.Threading;

namespace 線程的異常處理
{
    class Program
    {
        static void Main(string[] args)
        {

            new Thread(Go).Start();

            // //拋出異常無法捕獲
            // try
            // {
            //     new Thread(Go).Start();
            // }
            // catch (Exception )
            // {

            //     System.Console.WriteLine("!!!!!!!!");
            // }
        }
        //需要將異常捕獲寫在方法中
        static void Go()
        {
            try
            {
                throw null;
            }
            catch
            {

                System.Console.WriteLine("!!!!!!!");
            }
        }
    }
}
